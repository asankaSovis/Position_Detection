# 📌 Indoor Positioning System 

 ![Poster](https://user-images.githubusercontent.com/46389631/209512172-c9f438bc-3d70-4095-976f-8eeb61d6b27e.png)

---

*💸 Please consider [donating](https://www.paypal.com/donate/?hosted_button_id=4EWXTWQ9FUFLA) on Paypal to keep this project alive.*

## 📌 Project Introduction

The idea of this project is to build a system that uses the existing lights to detect the location of a user within an indoor environment. For this, we can use [Visible Light Communication (VLC)](https://en.wikipedia.org/wiki/Visible_light_communication) technology. The basic concept is to have four LEDs transmitting their IDs one after the other at fixed intervals. The reciever can recieve the IDs and identify how the intensity differs between each LED and decide the position of itself within an environment.

## ⚙️ Components

### 01. Altera Cyclone DE0-Nano

The Altera Cyclone DE0-Nano is an FPGA development board specially designed for students to experiment with FPGA technology. The Altera board is used in this project for the client side processes. This includes:
01. Reading intensity from a photodiode
02. Identifying the ID of the LED
03. Identifying the position of the user within the space
04. Transmitting this information to the display

### 02. Photodiode

This is used to get intensity readings from the surrounding. Connected to the FPGA, it will handle sending analog data to the FPGA containing the intensity changes. Any regular photodiode with average accuracy will be sufficient.

### 03. USB to TTL Converter Module

The USB to TTL Module is used by the FPGA to send the information to the serial port of a device. In this project, the results will be sent to a computer where a C# program will display this information on the computer.

### 04. Arduino

An arduino wil act as the transmitter. It will transmit the ID of each LED successiely at fixed intervals for the reciever to detect its location. Any Arduino is applicable for this purpose while an Arduino Uno was used in this project.

### 05. Light Emitting Diodes (LEDs)

LEDs are positioned at different points to signal the position of the user. For this any LED will be suitable while an LED with higher watt count will be more convenient.

### 06. LED Driver Circuit (Optional)

An optional LED drive circuit is required if you use high powered LEDs. In this case, the following components will be required to build one.

01. 5V boost converter *x4*
02. IRF840 N-channel Power MOSFET or equivalent *x4*
03. 1k resistor *x4*
04. Connection headers (Optional)
05. 5V power supply with a power rating matching the four LEDs

### 07. Computer with Position Display software

The software is optional as any regular connection to the right serial port can read the information that is sent. However, the software is written to decode the signals recieved and to display it in a user friendly way.

*More information will be added...*

`© 2022 Asanka Sovis`
