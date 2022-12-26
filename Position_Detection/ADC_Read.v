module ADC_Read (int_clk, dout, cs, din, areading, read_clk);

	input int_clk, dout;
	output cs, din, read_clk;
	output [11:0] areading;
	
	ADC_signalling module1 (read_clk, threshold, dout, areading);
	rec_clock module2 (int_clk, read_clk);
	
	assign cs = 0;
	assign din = 0;

endmodule

module ADC_signalling (clk, threshold, dout, areading);

    input clk, dout;
	 input [11:0] threshold;
	 
	 output reg [11:0] areading;

    reg [3:0] counter = 4'b1011;
	 reg [11:0] cache = 12'b0000_0000_0000;

    always @(negedge clk) begin
        counter = counter + 4'b0001;

        if (~(counter[2] && counter[3]))
            cache [counter] <= dout;
				
			if (counter[0] && counter[1] && counter[2] && counter[3]) begin
				areading[11] <= cache[0];
				areading[10] <= cache[1];
				areading[9] <= cache[2];
				areading[8] <= cache[3];
				areading[7] <= cache[4];
				areading[6] <= cache[5];
				areading[5] <= cache[6];
				areading[4] <= cache[7];
				areading[3] <= cache[8];
				areading[2] <= cache[9];
				areading[1] <= cache[10];
				areading[0] <= cache[11];
			end
				
			
				
    end


endmodule

// Recieving clock
// Creates a clock for reading purposes that matches 9600baud
module rec_clock(int_clk, clk);

	input int_clk; // Internal 50MHz clock
	output reg clk; // Output clock
	
	reg [15:0] divider; // Divider for timing
	
	initial begin
		divider <= 16'b0000_0000_0000;
	end
	
	always @(posedge int_clk) begin
	
		clk <= divider[15];
		divider = divider + 16'b0000_0000_0001;
	
	end

endmodule

module analog_2_digital(int_clk, analog_data, digital_data, threshold);
	
	input int_clk;
	input [11:0] analog_data, threshold;
	output reg digital_data;
	
	always @(posedge int_clk) begin
		digital_data <= (analog_data > threshold);
	end


endmodule