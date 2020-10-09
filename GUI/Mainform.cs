/*******************************************************************************
* Copyright (C) Maxim Integrated Products, Inc., All rights Reserved.
* 
* This software is protected by copyright laws of the United States and
* of foreign countries. This material may also be protected by patent laws
* and technology transfer regulations of the United States and of foreign
* countries. This software is furnished under a license agreement and/or a
* nondisclosure agreement and may only be used or reproduced in accordance
* with the terms of those agreements. Dissemination of this information to
* any party or parties not specified in the license agreement and/or
* nondisclosure agreement is expressly prohibited.
*
* The above copyright notice and this permission notice shall be included
* in all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
* OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
* MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
* IN NO EVENT SHALL MAXIM INTEGRATED BE LIABLE FOR ANY CLAIM, DAMAGES
* OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
* ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
* OTHER DEALINGS IN THE SOFTWARE.
*
* Except as contained in this notice, the name of Maxim Integrated
* Products, Inc. shall not be used except as stated in the Maxim Integrated
* Products, Inc. Branding Policy.
*
* The mere transfer of this software does not imply any licenses
* of trade secrets, proprietary technology, copyrights, patents,
* trademarks, maskwork rights, or any other form of intellectual
* property whatsoever. Maxim Integrated Products, Inc. retains all
* ownership rights.
*******************************************************************************
*/
/**
* @file       Mainform.cs
* @brief      This is the main form (window) of the generic GUI template with serial port connection.
* @version    1.0
* @notes      Dependent files and compilers:
*             1. maximlogo_YGT_icon.ico -- icon for this GUI.
*             2. SerialUSBForm.cs -- The form/window that appears to connect 
*             the GUI to serial port.
*             3. SplashScreen.cs -- The form/window that displays Maxim's 
*             "Look and Feel" screen for 3 seconds at startup.
*             4. Compiler: Microsoft Visual Studio Professional 2017.
*****************************************************************************/

using MaximStyle;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace RawI2CInterface
{
    public partial class Mainform : Form
    {
        // Max CODE
       /******************Variable declaration for I2C COM PORT***************/
        string dataOUT;
        string read     = "r" ;
        string write    = "w" ;
        string dataIN;
        /*******************************************************************/


        SplashScreen maximSplashScreenForm;
        SerialUSBForm USBform;
        List<string> KnownRomIDs = new List<string>();

        /* Delagates for Event Handling */
        public delegate void ReadDelegate(string in_data);
        public ReadDelegate mySerialDelegate;

        /**************************Main Form Intitialize***********************************
        Mainform() is the Constructor for the entire Windows Application. 
        @note	This method instantiates Mainform
        *******************************************************************************/
        public Mainform()
        {
            InitializeComponent();
        }

        /************************Mainform Setting Load*********************************
        Mainform_Load(Object sender, EventArgs e) draws the main window.  
        The code in this method sets up the form appropriately.  
        The splash screen form and the serial port connection form both get instantiated here. 
        The application's state shall be read from Properties.Settings.Default 
        Restored to the main Window's GUI controls.
                
        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ****************************************************************************/
        private void Mainform_Load(object sender, EventArgs e)
        {
           
            /* Create Splash Screen Form */
            maximSplashScreenForm = new SplashScreen(3);
            maximSplashScreenForm.disableCheckBoxValue = Properties.Settings.Default.disableSplashValue;
            maximSplashScreenForm.showOKButton(false);
            if (!maximSplashScreenForm.disableCheckBoxValue)
            {
                maximSplashScreenForm.ShowDialog();
            }

          
            /* Setup SerialUSB Form */
            USBform = new SerialUSBForm(serialPort1);
            USBform.ShowDialog();

            /* Subscribe to event DataReceived with the onDataReceived Function */
            serialPort1.DataReceived += this.SerialPort1_DataReceived;

            /* Initial Communication between GUI & FW */
            try
            {
                // serialPort1.WriteLine("INIT \n");
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("You are not connected to a Serial Port!", "Serial Error");
                return;
            }

            /* Setup Default Setting for Application */
            chBoxAddToOldData.Checked = false;
            chBoxAlwaysUpdate.Checked = true;

            chBoxRtsEnable.Checked = false;
            serialPort1.RtsEnable = false;

        }

        /**********************************Process Receive Data***************************************
        SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e).  
        The code in this event method gets called when serial port activity is sensed. 
        The code attempts to perform a Readline() 

        Note that this example uses the MAX32630FTHR I2C COM PORT Application firmware located here:
        .........................................................................................
        @param	sender	The sender of the event.
        @param	e	The SerialDataReceivedEventArgs arguments for the event.
        ********************************************************************************************/
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Receiving Data Function 
            // dataIN = serialPort1.ReadExisting();
            dataIN = serialPort1.ReadLine();
            // Must have this line to show data on the textBox directly 
            this.Invoke(new EventHandler(ShowData));
        }
       /***************************************Fomat Display Data*************************************
       ShowData(object sender, EventArgs e) 
       The code in this event method gets called when serial port activity is sensed. 
       The code attempts to perform a Readline() 

       Note that this example uses the MAX32630FTHR I2C COM PORT Application firmware located here:
       .........................................................................................
       @param	sender	The sender of the event.
       @param	e	The SerialDataReceivedEventArgs arguments for the event.
       ***********************************************************************************************/

        private void ShowData(object sender, EventArgs e)
        {
            // show data configuration
            int dataInLength = dataIN.Length;
            lblDataInLength.Text = string.Format("{0:00}", dataInLength);
            if (chBoxAlwaysUpdate.Checked)
            {
                tBoxDataIn.Text = dataIN;

            }
            else if (chBoxAddToOldData.Checked)
            {
                tBoxDataIn.Text += dataIN;
            }
        }

        /**************************************Error handling**************************************
        SerialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        This event gets called by the application when a serial port error is generated. 
        It will show the message "Error reading serial port" and 
        close/disconnect the serial port if it is open.
                       
        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ********************************************************************************************/
        private void SerialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show("Error reading serial port");
            if (!serialPort1.IsOpen)
            {
                maximStatusStrip1.SectionStatus.Text = "Disconnected (Error Received)";
            }
        }

        /*****************************Change COM PORT******************************************
        SerialPort1_PinChanged(object sender, SerialPinChangedEventArgs e). 
        This event gets called by the application when a serial port changes configuration. 
        It will show the message "Serial Pin Changed" and 
        close/disconnect the serial port if it is open.
                              
        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ****************************************************************************************/
        private void SerialPort1_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            MessageBox.Show("Serial Pin Changed");
            if (!serialPort1.IsOpen)
            {
                maximStatusStrip1.SectionStatus.Text = "Disconnected (Pin Change)";
            }
        }

        /************************ Show Connect Status**********************************
        MainForm_Shown(object sender, EventArgs e).  
        This event gets called by the application 
        After the Mainform_Load event but before the form becomes visible.
        This is where the MaximStatusStrip gets updated with serial port connection info
                              
        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ****************************************************************************/
        private void Mainform_Shown(object sender, EventArgs e)
        {
            maximStatusStrip1.SectionMessages.Text = "";

            if (serialPort1.IsOpen)
            {
                maximStatusStrip1.SectionStatus.Text = "Connected to " + serialPort1.PortName.ToString() + " @" + serialPort1.BaudRate.ToString();
            }
            else
            {
                maximStatusStrip1.SectionStatus.Text = "Disconnected";
                maximStatusStrip1.SectionDetails1.Text = " ";
            }
        }

        /*****************************Exitting Prgram*********************************
        ExitToolStripMenuItem_Click(object sender, EventArgs e). 
        This event gets called by the application 
        when the File -> Exit menu item gets clicked.
                              
        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ****************************************************************************/
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**************************Connect COM Port*************************************
        ConnectToolStripMenuItem_Click(object sender, EventArgs e).  
        This event gets called by the application.
        When the menu item Device --> Connect gets clicked.
                              
        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ****************************************************************************/
        private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USBform.ShowDialog();
            if (serialPort1.IsOpen)
            {
                maximStatusStrip1.SectionStatus.Text = "Connected to " + serialPort1.PortName.ToString() + " @" + serialPort1.BaudRate.ToString();
            }
            else
            {
                maximStatusStrip1.SectionStatus.Text = "Disconnected";
            }
        }

        /***********************************************************************
        AboutToolStripMenuItem_Click(object sender, EventArgs e).  
        This event gets called by the application 
        When the menu item Help --> About gets clicked.
                             
        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ****************************************************************************/
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            maximSplashScreenForm.showOKButton(true);
            maximSplashScreenForm.setDismissTime(100000); // set dismiss time to a very long time for the "About" click.
            maximSplashScreenForm.ShowDialog();
        }

        /**********************************Saving Button***********************************
        Mainform_FormClosing(object sender, FormClosingEventArgs e).  
        This event gets called by the application.
        when the user (or OS) attempts to close/exit the application.
        This is where the state of the program gets saved. 
        In this case, it is made up of the Splash Screen's disable check box checkmark value.
                              
        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ****************************************************************************/
        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.disableSplashValue = maximSplashScreenForm.disableCheckBoxValue;
            Properties.Settings.Default.Save();
        }


        /**********************************Read Button***********************************
        btnRead_Click(object sender, EventArgs e)  
        This event gets called by the application.
        when the user (or OS) attempts to execute READ Register button.
        It will execute the READ command of firmware I2C Application
        Status Bar also turn-on to indicate the transaction. 
                              
        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ****************************************************************************/
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = read + " " + tBoxSlave.Text + " " + tBoxRegister.Text + " " + tBoxNumByte.Text + "\r\n";
                serialPort1.WriteLine(dataOUT);
                progressBarRead.Value = 100;
                progressBarWrite.Value = 0;
            }
        }
        /**********************************Write Button**********************************
        btnWrite_Click(object sender, EventArgs e)
        This event gets called by the application.
        when the user (or OS) attempts to execute WRITE Register button.
        It will execute the READ command of firmware I2C Application
        Status Bar also turn-on to indicate the transaction. 
                              
        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ********************************************************************************/
        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = write + " " + tBoxSlave.Text + " " + tBoxRegister.Text + " " + tBoxByteValue.Text + "\r\n";
                serialPort1.WriteLine(dataOUT);
                progressBarWrite.Value = 100;
                progressBarRead.Value = 0;
            }
        }

        /*******************************Clear Receiver Sreeen*****************************
        btnClearScreen_Click(object sender, EventArgs e)
        This event gets called by the application.
        when the user (or OS) attempts to Clear Receiver Screen TextBox.
                              
        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ***********************************************************************************/
        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            if (tBoxDataIn.Text != "")
            {
                tBoxDataIn.Text = "";
            }
        }


        /*******************************Add to Old Data*****************************
        chBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        This event gets called by the application.
        when the user (or OS) attempts to add previous value to current value 
        User will need this option to READ Multi-Byte 
                              
        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ***********************************************************************************/
        private void chBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAddToOldData.Checked)
            {
                chBoxAlwaysUpdate.Checked = false;
                chBoxAddToOldData.Checked = true;
            }
            else
            {
                chBoxAlwaysUpdate.Checked = true;
            }

        }
        /**********************************Always Update*************************************
         chBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
         This event gets called by the application.
         when the user (or OS) attempts to update screen new value, and remove old value
         User can use this option to READ or WRITE Sngle-Byte.

         @param	sender	The sender of the event.
         @param	e	The arguments for the event.
        ***********************************************************************************/
        private void chBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAlwaysUpdate.Checked)
            {
                chBoxAlwaysUpdate.Checked = true;
                chBoxAddToOldData.Checked = false;
            }
            else
            {
                chBoxAddToOldData.Checked = true;
            }
        }

        /**************************Request To Send (RTS enable)******************************
        chBoxRtsEnable_CheckedChanged_1(object sender, EventArgs e)
        This event gets called by the application.(Flow-Control)
        RTS allow the receiver and the transmitter to alert each other to their state
        A transmitter raises its RTS line, which causes an interrupt on the receiver

        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ***********************************************************************************/
        private void chBoxRtsEnable_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chBoxRtsEnable.Checked)
            {
                serialPort1.RtsEnable = true;
                //MessageBox.Show("RTS Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { serialPort1.RtsEnable = false; }
        }

        /**************************Data Determine Ready(DTR enable)*******************************
        chBoxDtrEnable_CheckedChanged(object sender, EventArgs e)
        This event gets called by the application.(Flow-Control)
        DTR allow the receiver and the transmitter to alert each other to their state 
        It indicates that the connected device is ready to receive data. 
        It is checked-TRUE by default
        User will need that to work for the application firmware.

        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ***************************************************************************************/
        private void chBoxDtrEnable_CheckedChanged(object sender, EventArgs e)
        {
            // DTR enable
            if (chBoxDtrEnable.Checked)
            {
                serialPort1.DtrEnable = true;
                //MessageBox.Show("DTR Enable", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { serialPort1.DtrEnable = false; }
        }

       /*********************************Clear Grid Button********************************
        maximButton1_Click(object sender, EventArgs e)
        This event gets called by the application.
        when the user (or OS) attempts to Clear save data in grid.
                              
        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
       ***********************************************************************************/
        private void maximButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        /*********************************Add Read Button***********************************
        btnAddRead_Click(object sender, EventArgs e)
        This event gets called by the application.
        when the user (or OS) attempts to add READ value to the grid.

        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ***********************************************************************************/
        private void btnAddRead_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { "READ", tBoxRegister.Text, tBoxDataIn.Text };
            dataGridView1.Rows.Add(row);
        }

        /*******************************Add Write Button********************************
        btnAddWrite_Click(object sender, EventArgs e)
        This event gets called by the application.
        when the user (or OS) attempts to add WRITE value + Status to the grid.

        @param	sender	The sender of the event.
        @param	e	The arguments for the event.
        ***********************************************************************************/
        private void btnAddWrite_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { "WRITE", tBoxRegister.Text, tBoxByteValue.Text, tBoxDataIn.Text };
            dataGridView1.Rows.Add(row);
        }

    }
}
