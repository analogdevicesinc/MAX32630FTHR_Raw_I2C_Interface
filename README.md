# MAX32630FTHR Raw I2C Interface

## Introduction
This document discusses using the Graphic User Interface(GUI) for the MAX32630FTHR Raw I2C Interface application. It requires that the firmware found in the ./firmware directory be first loaded on the MAX32630FTHR (FTHR), and the device connected to a PC through the appropriate USB cable.

## Description
The GUI for the MAX32630FTHR Raw I2C Interface application was developed to provide an easy-to-use utility to test I2C chips in the field using the MAX32630FTHR board's I2C Master 1 I2C port. 

These instructions describe the program connected to an I2C temperature sensor, the MAX30208.  
	-**Single byte READ mode:** PART_ID Register (READ ONLY)
	-**Double byte READ mode:** FiFO_Data Register (READ ONLY)
	-**Single byte WRITE mode:** LOW_ALARM_LSB Register (READ and WRITE)

## Download
- Click the "Clone or Download" button and click "Download ZIP" above (from the main GITHUB repo page). After the download finishes, unzip the archive to the directory of choice. All the files needed to run the board can be found in the "firmware" and GUI directories. 
- Program the FTHR board with the .bin file found in the Firmware directory. Once the MAX32625PICO (programmer that comes with the FTHR board) is plugged into the PC, this is a simple drag and drop of the file onto the hard drive labeled "Daplink" or "mbed".
- Install the GUI by double-clicking setup.exe located in the .\GUI\Publish directory.


## Setup:
- The MAX32630FTHR must be attached to your PC via Serial Port for the communication pathway to be established between the GUI and the FTHR.
- The I2C devices can be powered off the MAX32630FTHR with 3.3-5V.
- A logic analyzer or oscilloscope is helpful to connect to the bus and see the waveforms being generated by the I2C Master and Slaves.
- The FTHR must be loaded with the distributed firmware and the GUI must be installed on your PC.
When the GUI process begins, the Maxim Splash Screen will appear. See screenshot below.
- After 3 seconds, the Maxim Splash Screen will disappear and the 'Connect to Serial Port' screen will appear. This screen is where you will connect your serial port to the FTHR.
- Press the 'Search' button to populate the list of COM ports. Select the COM port that the FTHR is connected to, and press the 'Connect' button.  See the COM PORT Selection screenshot below.
- Once you are connected to a Serial port, the Main Program will appear and give notice of the COM port and Baud rate, as well as the firmware version.  


### Splash Screen
![Splash Screen](/GUI/screenshots/splash_screen.png)

### Serial USB COM PORT Selection Screen
![COM Port Selection](/GUI/screenshots/serial_connect.png)

### Main Window
![Main Form Screen](/GUI/screenshots/main_form.png)

## Functionality
1.	The program initializes and sets up I2C Master1 of MAX32630FTHR

2.	The program blinks a blue LED light while it is running

3.	The GUI program offers the ability to WRITE single byte to: 
    - Input: 	SlaveAddress
    - Input: 	RegisterAddress
    - Input: 	Value <br>
Return 0 on successful write;  “ACK” string output screen <br>
Return 1 on failure write; “NACK” string output screen

4.	The GUI can READ N-bytes from:
    - Input: 	SlaveAddress
    -	Input: 	RegisterAddress
    -	Input: 	Number of Byte
    -	Output:  Value <br>
Return 0 on successful write;  “ACK” string output screen <br>
Return 1 on failure write; “NACK” string output screen

5.	Program should be able to process Input and Output from PC serial COM Port

## Operating Modes
**Single Byte READ Mode**: Slave address(0xA0) Register Address(0xFF) 
note: this numbered list matches the number in the screenshot below.
1. Place check in DTR Enable check box, input the slave address for the device, and input the register address.
2.	Place check in Last-Byte-Read check box. 
3.	Input the number of bytes, then click the READ button.
4.	The Clear Screen button will clear the output screen (the left text box under "Receiver Control").
5.	The Add Read Value button will add the record of your last transaction.
6.	The Clear Grid button will empty the table (the right-hand grid under "Receiver Control").

![Single Byte Read Mode](/GUI/screenshots/single_byte_mode.png)

**Multi Byte READ MODE**: Slave address(0xA0) Register Address(0x08)
note: this numbered list matches the number in the screenshot below.
1.	Place check in DTR enable check box, input the slave address device, and input the register address.
2.	Place check in Add To Old Data check box. 
3.	Input the number of bytes, then click the READ button.
4.	The Clear Screen button will clear the output screen. 
5.	The Add Read Value button will add the record of your last transaction.
6.	The Clear Grid button will empty the table.

![Multi Byte Read Mode](/GUI/screenshots/multi_byte_mode.png)

**Single Byte WRITE Mode**: Slave address(0xA0) Register Address(0x13)
note: this numbered list matches the number in the screenshot below.
1. Place check in DTR Enable check box, input the slave address for the device, and input the register address.
2.	Place check in Last-Byte-Read check box. 
3.	Input the byte value, then click the WRITE button.
4.	The Clear Screen button will clear the output screen. 
5.	The Add Read Value button will add the record of your last transaction.
6.	The Clear Grid button will empty the table.

![Single Byte Write Mode](/GUI/screenshots/single_byte_write.png)
