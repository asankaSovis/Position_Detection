using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Position_Detection
{
    public partial class frmMain : Form
    {
        string[] POSITION_NAMES = { "Position A", "Position B", "Position C", "Position D" };

        public SerialPort myPorts = null;

        Queue<int> readByte = new Queue< int>();

        int cacheByte = 0;

        int position = 0;
        int[] intensities = { 0, 0, 0, 0 };
        DateTime lastUpdate = DateTime.MinValue;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            reloadPorts();

            pcbImage.Image = Image.FromFile(Environment.CurrentDirectory + "/icon.png");

            //testData();
        }

        private void reloadPorts()
        {
            cmbPort.Items.Clear();

            cmbPort.Items.AddRange(SerialPort.GetPortNames());
            if (cmbPort.Items.Count > 0)
                cmbPort.SelectedIndex = 0;

            cmbBaud.SelectedItem = "9600";

            btnConnect.Text = "Connect";
            this.Text = "FPGA Positioning System";
        }

        private void connectToPort(string port, int bitrate)
        {
            btnConnect.Text = "Connect";
            myPorts = null;

            myPorts = new SerialPort(port, bitrate, Parity.None, 8, StopBits.One);
            myPorts.Handshake = Handshake.None;
            myPorts.DataReceived += new SerialDataReceivedEventHandler(portDataRecieved);
            myPorts.WriteTimeout = 500;

            if (!myPorts.IsOpen)
            {
                try
                {
                    myPorts.Open();
                    btnConnect.Text = "Disconnect";
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not connect to " + port + ". Check if it is open...", "FPGA Positioning System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void portDataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            if (myPorts != null)
            {
                for (int i = 0; i < myPorts.BytesToRead; i++)
                {
                    readByte.Enqueue(myPorts.ReadByte());
                }
            }

            lastUpdate= DateTime.Now;
            tssStatus.Text = "Last Update: just now";
        }

        private void drawPosition()
        {
            Image bmp = null;
            if (pcbPosition.Size.Width > pcbPosition.Size.Height)
                bmp = new Bitmap(pcbPosition.Size.Height, pcbPosition.Size.Height);
            else
                bmp = new Bitmap(pcbPosition.Size.Width, pcbPosition.Size.Width);

            using (Graphics gr = Graphics.FromImage(bmp))
            {
                gr.Clear(Color.White);

                int rows = (int)Math.Floor(Math.Sqrt(POSITION_NAMES.Length));
                int width = bmp.Width / rows;
                int height = bmp.Height / rows;

                for (int i = 0; i < POSITION_NAMES.Length; i++)
                {


                    int y = (int)Math.Floor((decimal)(i / rows));
                    int x = i - (y * rows);

                    if (position == i)
                        gr.FillRectangle(Brushes.PaleVioletRed, width * x, height * y, width, height);
                    else
                        gr.FillRectangle(Brushes.LightBlue, width * x, height * y, width, height);

                    gr.DrawRectangle(Pens.DarkBlue, width * x, height * y, width, height - 1);

                    gr.DrawString(POSITION_NAMES[i], SystemFonts.DefaultFont, Brushes.Black, (width * x) + (width / 2) - 30, (height * y) + (height / 2) - 10);
                    gr.DrawString("☼ " + intensities[i], SystemFonts.MessageBoxFont, Brushes.Black, (width * x) + 10, (height * y) + 10);
                }

                pcbPosition.Image = bmp;
            }
        }

        private void sendData(string command, int angle)
        {
            if ((myPorts != null) && (myPorts != null))
            {
                myPorts.WriteLine(command + ":" + angle);
            }
            else
            {
                MessageBox.Show("Could not connect to a port. Check if it is open...", "FPGA Positioning System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if ((myPorts == null) || !myPorts.IsOpen)
            {
                connectToPort(cmbPort.Text, int.Parse(cmbBaud.Text));
            }
            else
            {
                myPorts.Close();
                btnConnect.Text = "Connect";
            }
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            if (readByte.Count > 0)
            {
                for (int i = 0; i < readByte.Count; i++)
                {
                    int myByte = readByte.Dequeue();
                    txtRaw.Text += myByte.ToString("X2") + " ";

                    //
                    if (GetBit((byte)myByte, 7))
                    {
                        if (GetBit((byte)myByte, 6))
                        {
                            position = (cacheByte & 3);
                            //MessageBox.Show("Position: " + position);

                            positionUpdate();

                            txtRaw.Text += "\r\n";
                            tssProgress.Value = 5;
                        } else
                        {
                            int ledID = ((myByte & 48) >> 4);
                            intensities[ledID] = (((myByte & 15) << 8) + ((cacheByte & 127) << 1));
                            //MessageBox.Show("LED ID: " + ((myByte & 48) >> 4) + " | Intensity: " + intensities[((myByte & 48) >> 4)]);

                            intensityUpdate(ledID);

                            tssProgress.Value = ledID + 1;
                        }
                        
                    } else
                    {
                        cacheByte = myByte;
                    }
                }
            }

            TimeSpan duration = DateTime.Now.Subtract(lastUpdate);

            if (lastUpdate.Equals(DateTime.MinValue))
                tssStatus.Text = "Last Update: never";
            else if (duration.Hours > 0)
                tssStatus.Text = "Last Update: " + (duration).Hours + " hours, " + (duration).Minutes + " minutes and " + (duration).Seconds + " seconds ago";
            else if (duration.Minutes > 0)
                tssStatus.Text = "Last Update: " + (duration).Minutes + " minute and " + (duration).Seconds + " seconds ago";
            else if (duration.Seconds == 0)
                tssStatus.Text = "Last Update: just now";
            else
                tssStatus.Text = "Last Update: " + (duration).Seconds + " seconds ago";

            if (duration.TotalSeconds > 4)
                tssProgress.Style = ProgressBarStyle.Marquee;
            else
                tssProgress.Style = ProgressBarStyle.Continuous;
        }

        private void intensityUpdate(int ledID)
        {
            txtUpdate.Text += "Intensity Update for LED " + ledID + ": " + intensities[ledID] + "\r\n";

            drawPosition();
        }

        private void positionUpdate()
        {
            txtUpdate.Text += "Position Update: " + POSITION_NAMES[position] + "\r\n";

            drawPosition();
        }

        private bool GetBit(byte b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }

        private void cmbBaud_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled = ((cmbBaud.TabIndex >= 0) && (cmbPort.SelectedIndex >= 0));
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            drawPosition();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            spcText.Panel1Collapsed = !spcText.Panel1Collapsed;

            if (spcText.Panel1Collapsed) { btnCollapse.Text = "▼ Expand Raw Data View"; }
            else { btnCollapse.Text = "▲ Collapse Raw Data View"; }
        }

        private void testData()
        {
            readByte.Enqueue(77);
            readByte.Enqueue(173);

            readByte.Enqueue(76);
            readByte.Enqueue(157);

            readByte.Enqueue(75);
            readByte.Enqueue(189);

            readByte.Enqueue(74);
            readByte.Enqueue(141);

            readByte.Enqueue(1);
            readByte.Enqueue(192);

            readByte.Enqueue(77);
            readByte.Enqueue(173);

            readByte.Enqueue(76);
            readByte.Enqueue(157);

            readByte.Enqueue(75);
            readByte.Enqueue(189);

            readByte.Enqueue(74);
            readByte.Enqueue(141);

            readByte.Enqueue(1);
            readByte.Enqueue(192);

            portDataRecieved(null, null);
        }

        private void pcbImage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                      ~FPGA POSITIONING SYSTEM v1.0~\r\n\r\nPositioning system to accompany the User Positioning System developed in FPGA using VLC.\r\n\r\n                                    © Asanka Sovis", "About FPGA Positioning System", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
