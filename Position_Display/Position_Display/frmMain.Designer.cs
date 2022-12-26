namespace Position_Detection
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.stsMain = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssEmpty = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tlpConnect = new System.Windows.Forms.TableLayoutPanel();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.tlpPosition = new System.Windows.Forms.TableLayoutPanel();
            this.grpPosition = new System.Windows.Forms.GroupBox();
            this.pcbPosition = new System.Windows.Forms.PictureBox();
            this.grpUpdates = new System.Windows.Forms.GroupBox();
            this.tlpUpdates = new System.Windows.Forms.TableLayoutPanel();
            this.spcText = new System.Windows.Forms.SplitContainer();
            this.txtRaw = new System.Windows.Forms.TextBox();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.stsMain.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.tlpControls.SuspendLayout();
            this.tlpConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.tlpPosition.SuspendLayout();
            this.grpPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPosition)).BeginInit();
            this.grpUpdates.SuspendLayout();
            this.tlpUpdates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcText)).BeginInit();
            this.spcText.Panel1.SuspendLayout();
            this.spcText.Panel2.SuspendLayout();
            this.spcText.SuspendLayout();
            this.SuspendLayout();
            // 
            // stsMain
            // 
            this.stsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssEmpty,
            this.tssProgress});
            this.stsMain.Location = new System.Drawing.Point(0, 634);
            this.stsMain.Name = "stsMain";
            this.stsMain.Size = new System.Drawing.Size(800, 22);
            this.stsMain.TabIndex = 0;
            this.stsMain.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(99, 17);
            this.tssStatus.Text = "Last Update: NaN";
            // 
            // tssEmpty
            // 
            this.tssEmpty.Name = "tssEmpty";
            this.tssEmpty.Size = new System.Drawing.Size(484, 17);
            this.tssEmpty.Spring = true;
            // 
            // tssProgress
            // 
            this.tssProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tssProgress.Maximum = 5;
            this.tssProgress.Name = "tssProgress";
            this.tssProgress.Size = new System.Drawing.Size(200, 16);
            this.tssProgress.Step = 1;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.grpControls, 0, 0);
            this.tlpMain.Controls.Add(this.tlpPosition, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(800, 634);
            this.tlpMain.TabIndex = 1;
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.tlpControls);
            this.grpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpControls.Location = new System.Drawing.Point(3, 3);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(794, 77);
            this.grpControls.TabIndex = 0;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // tlpControls
            // 
            this.tlpControls.ColumnCount = 4;
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpControls.Controls.Add(this.btnConnect, 0, 0);
            this.tlpControls.Controls.Add(this.tlpConnect, 1, 0);
            this.tlpControls.Controls.Add(this.pcbImage, 3, 0);
            this.tlpControls.Controls.Add(this.lblText, 2, 0);
            this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControls.Location = new System.Drawing.Point(3, 16);
            this.tlpControls.Name = "tlpControls";
            this.tlpControls.RowCount = 1;
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpControls.Size = new System.Drawing.Size(788, 58);
            this.tlpControls.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(3, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 52);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tlpConnect
            // 
            this.tlpConnect.ColumnCount = 1;
            this.tlpConnect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConnect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpConnect.Controls.Add(this.cmbBaud, 0, 0);
            this.tlpConnect.Controls.Add(this.cmbPort, 0, 1);
            this.tlpConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConnect.Location = new System.Drawing.Point(129, 3);
            this.tlpConnect.Name = "tlpConnect";
            this.tlpConnect.RowCount = 2;
            this.tlpConnect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpConnect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpConnect.Size = new System.Drawing.Size(160, 52);
            this.tlpConnect.TabIndex = 1;
            // 
            // cmbBaud
            // 
            this.cmbBaud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            "115200",
            "1200",
            "19200",
            "2400",
            "38400",
            "4800",
            "57600",
            "9600"});
            this.cmbBaud.Location = new System.Drawing.Point(3, 3);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(154, 21);
            this.cmbBaud.TabIndex = 0;
            this.cmbBaud.SelectedIndexChanged += new System.EventHandler(this.cmbBaud_SelectedIndexChanged);
            // 
            // cmbPort
            // 
            this.cmbPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(3, 29);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(154, 21);
            this.cmbPort.TabIndex = 1;
            // 
            // pcbImage
            // 
            this.pcbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbImage.Location = new System.Drawing.Point(727, 3);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(58, 52);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImage.TabIndex = 2;
            this.pcbImage.TabStop = false;
            this.pcbImage.Click += new System.EventHandler(this.pcbImage_Click);
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(295, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(426, 58);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "POSITIONING SYSTEM";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpPosition
            // 
            this.tlpPosition.ColumnCount = 2;
            this.tlpPosition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPosition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tlpPosition.Controls.Add(this.grpPosition, 0, 0);
            this.tlpPosition.Controls.Add(this.grpUpdates, 1, 0);
            this.tlpPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPosition.Location = new System.Drawing.Point(3, 86);
            this.tlpPosition.Name = "tlpPosition";
            this.tlpPosition.RowCount = 1;
            this.tlpPosition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPosition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPosition.Size = new System.Drawing.Size(794, 545);
            this.tlpPosition.TabIndex = 1;
            // 
            // grpPosition
            // 
            this.grpPosition.Controls.Add(this.pcbPosition);
            this.grpPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPosition.Location = new System.Drawing.Point(3, 3);
            this.grpPosition.Name = "grpPosition";
            this.grpPosition.Size = new System.Drawing.Size(545, 539);
            this.grpPosition.TabIndex = 0;
            this.grpPosition.TabStop = false;
            this.grpPosition.Text = "Position";
            // 
            // pcbPosition
            // 
            this.pcbPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbPosition.Location = new System.Drawing.Point(3, 16);
            this.pcbPosition.Name = "pcbPosition";
            this.pcbPosition.Size = new System.Drawing.Size(539, 520);
            this.pcbPosition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPosition.TabIndex = 1;
            this.pcbPosition.TabStop = false;
            // 
            // grpUpdates
            // 
            this.grpUpdates.Controls.Add(this.tlpUpdates);
            this.grpUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUpdates.Location = new System.Drawing.Point(554, 3);
            this.grpUpdates.Name = "grpUpdates";
            this.grpUpdates.Size = new System.Drawing.Size(237, 539);
            this.grpUpdates.TabIndex = 1;
            this.grpUpdates.TabStop = false;
            this.grpUpdates.Text = "Updates";
            // 
            // tlpUpdates
            // 
            this.tlpUpdates.ColumnCount = 1;
            this.tlpUpdates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUpdates.Controls.Add(this.spcText, 0, 1);
            this.tlpUpdates.Controls.Add(this.btnCollapse, 0, 0);
            this.tlpUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUpdates.Location = new System.Drawing.Point(3, 16);
            this.tlpUpdates.Name = "tlpUpdates";
            this.tlpUpdates.RowCount = 3;
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.92958F));
            this.tlpUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.07042F));
            this.tlpUpdates.Size = new System.Drawing.Size(231, 520);
            this.tlpUpdates.TabIndex = 0;
            // 
            // spcText
            // 
            this.spcText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcText.Location = new System.Drawing.Point(3, 33);
            this.spcText.Name = "spcText";
            this.spcText.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcText.Panel1
            // 
            this.spcText.Panel1.Controls.Add(this.txtRaw);
            this.spcText.Panel1Collapsed = true;
            // 
            // spcText.Panel2
            // 
            this.spcText.Panel2.Controls.Add(this.txtUpdate);
            this.spcText.Size = new System.Drawing.Size(225, 385);
            this.spcText.SplitterDistance = 67;
            this.spcText.TabIndex = 0;
            // 
            // txtRaw
            // 
            this.txtRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRaw.Location = new System.Drawing.Point(0, 0);
            this.txtRaw.Multiline = true;
            this.txtRaw.Name = "txtRaw";
            this.txtRaw.ReadOnly = true;
            this.txtRaw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRaw.Size = new System.Drawing.Size(150, 67);
            this.txtRaw.TabIndex = 0;
            // 
            // txtUpdate
            // 
            this.txtUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUpdate.Location = new System.Drawing.Point(0, 0);
            this.txtUpdate.Multiline = true;
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.ReadOnly = true;
            this.txtUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUpdate.Size = new System.Drawing.Size(225, 385);
            this.txtUpdate.TabIndex = 1;
            // 
            // btnCollapse
            // 
            this.btnCollapse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCollapse.Location = new System.Drawing.Point(3, 3);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(225, 24);
            this.btnCollapse.TabIndex = 1;
            this.btnCollapse.Text = "▼ Expand Raw Data View";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.stsMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 695);
            this.Name = "frmMain";
            this.Text = "FPGA Positioning System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.stsMain.ResumeLayout(false);
            this.stsMain.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.grpControls.ResumeLayout(false);
            this.tlpControls.ResumeLayout(false);
            this.tlpConnect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.tlpPosition.ResumeLayout(false);
            this.grpPosition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPosition)).EndInit();
            this.grpUpdates.ResumeLayout(false);
            this.tlpUpdates.ResumeLayout(false);
            this.spcText.Panel1.ResumeLayout(false);
            this.spcText.Panel1.PerformLayout();
            this.spcText.Panel2.ResumeLayout(false);
            this.spcText.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcText)).EndInit();
            this.spcText.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsMain;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.TableLayoutPanel tlpControls;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TableLayoutPanel tlpConnect;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.PictureBox pcbImage;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TableLayoutPanel tlpPosition;
        private System.Windows.Forms.GroupBox grpPosition;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.GroupBox grpUpdates;
        private System.Windows.Forms.TableLayoutPanel tlpUpdates;
        private System.Windows.Forms.SplitContainer spcText;
        private System.Windows.Forms.TextBox txtRaw;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.PictureBox pcbPosition;
        private System.Windows.Forms.ToolStripProgressBar tssProgress;
        private System.Windows.Forms.ToolStripStatusLabel tssEmpty;
    }
}

