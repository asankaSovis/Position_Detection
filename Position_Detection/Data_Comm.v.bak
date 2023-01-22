module data_comm(int_clk, trigger, adc_reading, led_id, data1, data2, send, trigger_id);

	wire [11:0] one_intensity;
	wire [11:0] two_intensity;
	wire [11:0] three_intensity;
	wire [11:0] four_intensity;
	
	wire [2:0] send_id;
	
	input int_clk;
	input trigger;
	input [11:0] adc_reading;
	input [7:0] led_id;
	
	output reg [7:0] data1;
	output reg [7:0] data2;
	output send;
	output trigger_id;
	
	read_intensity(trigger, adc_reading, led_id, one_intensity, two_intensity, three_intensity, four_intensity);
	comm_clock (int_clk, send, send_id, trigger_id);
	
	always @(posedge send) begin
		
		if (send_id == 3'b000) begin
			data1 [6:0] <= one_intensity [7:1];
			data2 [3:0] <= one_intensity [11:8];
		end else if (send_id == 3'b001) begin
			data1 [6:0] <= two_intensity [7:1];
			data2 [3:0] <= two_intensity [11:8];
		end else if (send_id == 3'b010) begin
			data1 [6:0] <= three_intensity [7:1];
			data2 [3:0] <= three_intensity [11:8];
		end else if (send_id == 3'b011) begin
			data1 [6:0] <= four_intensity [7:1];
			data2 [3:0] <= four_intensity [11:8];
		end else if (send_id == 3'b100) begin
			//data1 [7:0] <= 8'b0000_0000;
			data2 [3:0] <= 4'b0000;
			
			 if ((one_intensity > two_intensity) && (one_intensity > three_intensity) && (one_intensity > four_intensity)) begin
				data1 [7:0] <= 8'b0000_0000;
			 end else if ((two_intensity > one_intensity) && (two_intensity > three_intensity) && (two_intensity > four_intensity)) begin
				data1 [7:0] <= 8'b0000_0001;
			 end else if ((three_intensity > one_intensity) && (three_intensity > two_intensity) && (three_intensity > four_intensity)) begin
				data1 [7:0] <= 8'b0000_0010;
			 end else begin
				data1 [7:0] <= 8'b0000_0011;
			 end
		end
		
		data2 [6:4] <= send_id[2:0];
		data2 [7] <= trigger_id;
	
	end
	
endmodule

module read_intensity(trigger, adc_reading, led_id, one_intensity, two_intensity, three_intensity, four_intensity);
	
	input trigger;
	input [11:0] adc_reading;
	input [7:0] led_id;
	
	output reg [11:0] one_intensity;
	output reg [11:0] two_intensity;
	output reg [11:0] three_intensity;
	output reg [11:0] four_intensity;
	
	always @(posedge trigger) begin
	
		if (led_id == 8'b1010_1010) begin
			two_intensity <= adc_reading;
		end else if (led_id == 8'b0101_0101) begin
			one_intensity <= adc_reading;
		end else if (led_id == 8'b0101_1010) begin
			three_intensity <= adc_reading;
		end else if (led_id == 8'b1010_0101) begin
			four_intensity <= adc_reading;
		end
	
	end

endmodule

module comm_clock (int_clk, send, send_id, trigger_id);

	input int_clk;
	output reg [2:0] send_id;
	output reg send, trigger_id;
	
	reg [26:0] counter;
	
	
	reg [26:0] data1byte1 = 27'b101_1110_1110_0000_0010_1111_1000; // @1Hz
	reg [26:0] data1byte2 = 27'b101_1110_1110_1110_0010_1100_0000; // @2Hz
	
	reg [26:0] data2byte1 = 27'b101_1110_1111_1100_0010_1000_1000; // @1Hz
	reg [26:0] data2byte2 = 27'b101_1111_0000_1010_0010_0101_0000; // @2Hz
	
	reg [26:0] data3byte1 = 27'b101_1111_0001_1000_0010_0001_1000; // @1Hz
	reg [26:0] data3byte2 = 27'b101_1111_0010_0110_0001_1110_0000; // @2Hz
	
	reg [26:0] data4byte1 = 27'b101_1111_0011_0100_0001_1010_1000; // @1Hz
	reg [26:0] data4byte2 = 27'b101_1111_0100_0010_0001_0111_0000; // @2Hz
	
	reg [26:0] data5byte1 = 27'b101_1111_0101_0000_0001_0011_1000; // @1Hz
	reg [26:0] data5byte2 = 27'b101_1111_0101_1110_0001_0000_0000; // @2Hz
	
	initial begin
		counter <= 27'b000_0000_0000_0000_0000_0000_0000;
		send_id <= 3'b000;
	end
	
	always @(posedge int_clk) begin
		counter <= counter + 27'b000_000_0000_0000_0000_0000_0001;
		
		send = ((counter == data4byte1) || (counter == data4byte2) || (counter == data3byte1) || (counter == data3byte2) || (counter == data2byte1) || (counter == data2byte2) || (counter == data1byte1) || (counter == data1byte2) || (counter == data5byte1) || (counter == data5byte2));

		if (counter == data5byte2) begin
			counter <= 27'b000_0000_0000_0000_0000_0000_0000;
			trigger_id = 1;
		end else if (counter == data5byte1) begin
			trigger_id = 0;
			send_id <= 3'b100;
		end
		
		if (counter == data4byte2) begin
			trigger_id = 1;
		end else if (counter == data4byte1) begin
			trigger_id = 0;
			send_id <= 3'b011;
		end
		
		if (counter == data3byte2) begin
			trigger_id = 1;
		end else if (counter == data3byte1) begin
			trigger_id = 0;
			send_id <= 3'b010;
		end
		
		if (counter == data2byte2) begin
			trigger_id = 1;
		end else if (counter == data2byte1) begin
			trigger_id = 0;
			send_id <= 3'b001;
		end
		
		if (counter == data1byte2) begin
			trigger_id = 1;
		end else if (counter == data1byte1) begin
			trigger_id = 0;
			send_id <= 3'b000;
		end
	end

endmodule