# MAX32630FTHR Raw I2C Interface

## Introduction
This document discusses using the Graphic User Interface(GUI) for the MAX32630FTHR Raw I2C Interface application. It requires that the firmware found in the ./firmware directory be first loaded on the MAX32630FTHR, and the device connected to a PC through the appropriate USB cable.

## Description
The GUI for the MAX32630FTHR Raw I2C Interface application was developed to provide an easy-to-use utility to test I2C chips in the field using the MAX32630FTHR board's I2C Master 1 I2C port. 

These instructions describe the program connected to an I2C temperature sensor, the MAX30208.  
	**Single byte READ mode:** PART_ID Register (READ ONLY)
	**Double byte READ mode:** FiFO_Data Register (READ ONLY)
	**Single byte WRITE mode:** LOW_ALARM_LSB Register (READ and WRITE)


