# MAX32630FTHR Raw I2C Interface

## Introduction
This document discusses using the Graphic User Interface(GUI) for the MAX32630FTHR Raw I2C Interface application. It requires that the firmware found in the ./firmware directory be first loaded on the MAX32630FTHR, and the device connected to a PC through the appropriate USB cable.

## Description
The GUI for the MAX32630FTHR Raw I2C Interface application was developed to provide an easy-to-use utility to test I2C chips in the field using the MAX32630FTHR board's I2C Master 1 I2C port. 

These instructions describe the program connected to an I2C temperature sensor, the MAX30208.  
	-**Single byte READ mode:** PART_ID Register (READ ONLY)
	-**Double byte READ mode:** FiFO_Data Register (READ ONLY)
	-**Single byte WRITE mode:** LOW_ALARM_LSB Register (READ and WRITE)

### Splash Screen

### Serial USB COM PORT Selection Screen

### Main Form Screen

## Functionality
1.	Program should be able to initialize and setup I2C Master1 of MAX32630FTHR

2.	Program should be able to blink a blue LED light while it is running

3.	Program should be able to WRITE single byte to: 
- a.  Input: 	SlaveAddress
- b.	Input: 	RegisterAddress
- c.	Input: 	Value
Return 0 on successful write;  “ACK” string output screen 
Return 1 on failure write; “NACK” string output screen

4.	Program should be able to READ N-byte from:
-a.	Input: 	SlaveAddress
-b.	Input: 	RegisterAddress
-c.	Input: 	Number of Byte
-d.	Output: Value
Return 0 on successful write;  “ACK” string output screen 
Return 1 on failure write; “NACK” string output screen

5.	Program should be able to process Input and Output from PC serial COM Port
-a.	Maxim I2C COM Port GUI

