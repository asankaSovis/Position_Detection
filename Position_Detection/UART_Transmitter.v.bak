module UART_Transmitter (int_clk, trigger, trigger_ID, in_data1, in_data2, dout);

	input int_clk;
	input [7:0] in_data1;
	input [7:0] in_data2;
	input trigger, trigger_ID;
	output dout;
	wire [3:0] bit_ID;
	
	wire run;
	reg state;
	
	reg [7:0] data = 8'b0000_0000;
	
	initial begin
		state <= 0;
	end
	
	tx_clock module1 (int_clk, run, tx_clk);
	bit_counter module2 (tx_clk, bit_ID, enable);
	transmitter module3 (data, bit_ID, dout);
	//timed_trigger module4 (int_clk, trigger, trigger_ID);
	
	always @(posedge trigger or negedge enable) begin		
		if (trigger == 1) begin
		
			if (trigger_ID) begin
				data [7:0] <=  in_data2 [7:0];
			end else begin
				data [7:0] <=  in_data1 [7:0];
			end
				
			state = 1;
			
		end else begin
			state = 0;
		end
		
	end
	
	assign run = state;

endmodule

module transmitter (data, bit_ID, dout);
	
	input [7:0] data;
	input [3:0] bit_ID;
	output dout;
	
	wire [9:0] data_tx;
	
	assign data_tx[0] = 1; // End bit
	assign data_tx[1] = 0; // Start bit
	assign data_tx[9:2] = data[7:0];
	
	assign dout = data_tx[bit_ID];

endmodule

module bit_counter (tx_clk, bit_ID, enable);

	input tx_clk;
	output reg [3:0] bit_ID;
	output reg enable;
	
	initial begin
		bit_ID = 4'b0000;
	end
	
	always @(posedge tx_clk) begin
	
		if (bit_ID == 4'b1001) begin
			bit_ID = 4'b0000;
			enable = 0;
		end else begin
			bit_ID = bit_ID + 4'b0001;
			enable = 1;
		end
	
	end

endmodule

module tx_clock (int_clk, run, tx_clk);
	
	input int_clk, run;
	output reg tx_clk;
	
	reg [25:0] counter;
	//reg [25:0] tx_speed = 26'b01_0111_1101_0111_1000_0100_0000; // @1Hz
	reg [25:0] tx_speed = 26'b00_0000_0000_0000_1010_0010_1100; // @9.6kHz
	
	initial begin
		counter <= 26'b00_0000_0000_0000_0000_0000_0000;
	end
	
	always @(posedge int_clk) begin
	
		if (run) begin
			counter <= counter + 26'b00_000_0000_0000_0000_0000_0001;
			
			if (counter == tx_speed) begin
				counter <= 26'b00_0000_0000_0000_0000_0000_0000;
				tx_clk <= ~tx_clk;
			end
		end else begin
			counter <= tx_speed;
			tx_clk <= 0;
			
		end
	
	end

endmodule

module timed_trigger(int_clk, trigger, trigger_ID);

	input int_clk;
	output reg trigger, trigger_ID;
	
	reg [26:0] counter;
	reg [26:0] data1byte1 = 26'b1_0111_1101_0111_1000_0100_0000; // @1Hz
	reg [26:0] data1byte2 = 27'b101_1111_0101_1110_0001_0000_0000; // @0.5Hz
	
	initial begin
		counter <= 27'b000_0000_0000_0000_0000_0000_0000;
	end
	
	always @(posedge int_clk) begin
		counter <= counter + 27'b000_000_0000_0000_0000_0000_0001;
		
		trigger = ((counter == data1byte1) || (counter == data1byte2));
		
		if (counter == data1byte2) begin
			counter <= 27'b000_0000_0000_0000_0000_0000_0000;
			trigger_ID = 1;
		end else if (counter == data1byte1) begin
			trigger_ID = 0;
		end
	end

endmodule