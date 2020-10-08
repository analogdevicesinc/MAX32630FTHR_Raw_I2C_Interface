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
* @file       SerialUSBForm.cs
* @brief      This is the form (window) that the DS18B20 Config demo main window instantiates. 
*             This opens/appears before the main window to provide a way for the user to 
*             make a serial port connection. It scans the OS for available serial ports 
*             and offers these as connection selections.
* @version    1.0
* @notes      Dependent files and compilers:
*             1. This should be called by the main form, which is "Mainform.cs".
*             2. Compiler: Microsoft Visual Studio Professional 2017.
*****************************************************************************/
using MaximStyle;
using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Windows.Forms;

namespace GenericGUIProject
{

    public partial class SerialUSBForm : Form
    {
        private MaximButton MaximButton_connect_serial;
        private SerialPort ComPort1;
        private IContainer components;
        private ColumnHeader columnHeader;
        private ListBox listBox1;
        private MaximButton Refresh_List;
        SerialPort myserialport;

        /**
        SerialUSBForm() is the Constructor for the serial connection form. <br>

		@param[in] xyz is a SerialPort.
        @note	This method instantiates SerialUSBForm 
        ****************************************************************************/
        public SerialUSBForm(SerialPort xyz)
        {
            InitializeComponent();
            myserialport = xyz;
        }

        // MSVC generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialUSBForm));
            this.MaximButton_connect_serial = new MaximStyle.MaximButton();
            this.ComPort1 = new System.IO.Ports.SerialPort(this.components);
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Refresh_List = new MaximStyle.MaximButton();
            this.SuspendLayout();
            // 
            // MaximButton_connect_serial
            // 
            this.MaximButton_connect_serial.Location = new System.Drawing.Point(204, 157);
            this.MaximButton_connect_serial.Name = "MaximButton_connect_serial";
            this.MaximButton_connect_serial.Size = new System.Drawing.Size(75, 23);
            this.MaximButton_connect_serial.TabIndex = 2;
            this.MaximButton_connect_serial.Text = "Connect";
            this.MaximButton_connect_serial.UseVisualStyleBackColor = true;
            this.MaximButton_connect_serial.Click += new System.EventHandler(this.MaximButton_connect_serial_Click);
            // 
            // ComPort1
            // 
            this.ComPort1.PortName = "COM";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(146, 147);
            this.listBox1.TabIndex = 3;
            // 
            // Refresh_List
            // 
            this.Refresh_List.Location = new System.Drawing.Point(204, 33);
            this.Refresh_List.Name = "Refresh_List";
            this.Refresh_List.Size = new System.Drawing.Size(75, 23);
            this.Refresh_List.TabIndex = 4;
            this.Refresh_List.Text = "Refresh List";
            this.Refresh_List.UseVisualStyleBackColor = true;
            this.Refresh_List.Click += new System.EventHandler(this.Refresh_List_Click);
            // 
            // SerialUSBForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(309, 223);
            this.Controls.Add(this.Refresh_List);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.MaximButton_connect_serial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SerialUSBForm";
            this.Text = "Connect to Serial Device";
            this.Load += new System.EventHandler(this.SerialUSBForm_Load);
            this.ResumeLayout(false);

        }

        /**
        MaximButton_connect_serial_Click(Object sender, EventArgs e) reads the selected 
        serial port offered by the list box and and establishes a serial port connection 
        on the selected port. The serial port settings are hard coded to match the ones 
        in the firmware (9600 baud, 8 data bits, no parity, one stop bit, RTS and DTS 
        are both enabled, no handshake). This gets called when the "Connect" button gets 
        clicked.
                
        @param	sender	The sender of the event.
        @param	e	The arguments for the event
        <br>
        ****************************************************************************/
        private void MaximButton_connect_serial_Click(object sender, EventArgs e)
        {
            if (!(myserialport.IsOpen))
            {
                try
                {
                    myserialport.PortName = Convert.ToString(listBox1.SelectedItem);

                    myserialport.BaudRate = 9600;
                    myserialport.Parity = System.IO.Ports.Parity.None;
                    myserialport.DataBits = 8;
                    myserialport.StopBits = System.IO.Ports.StopBits.One;
                    myserialport.Handshake = System.IO.Ports.Handshake.None;
                    myserialport.RtsEnable = true;
                    myserialport.DtrEnable = true;

                    //
                    //myserialport.DataReceived += Mainform.serialPort1_onDataReceived;

                    try
                    {

                        myserialport.Open();

                    }
                    catch (System.ArgumentException ex)
                    {
                        ex.Data.Clear();
                        MessageBox.Show("Please select the Valid COM port and click connect", "Error: COM Port Not Selected");
                        return;
                    }

                    this.Hide();

                }
                catch (UnauthorizedAccessException ex)
                {
                    // ignore exception
                    //   MessageBox.Show(ex.Message);
                    ex.Data.Clear();
                }
            }
            else if (myserialport.IsOpen)
            {
                myserialport.Close();
                try
                {
                    myserialport.PortName = Convert.ToString(listBox1.SelectedItem);
                    myserialport.BaudRate = 9600;
                    myserialport.Parity = System.IO.Ports.Parity.None;
                    myserialport.DataBits = 8;
                    myserialport.StopBits = System.IO.Ports.StopBits.One;
                    myserialport.Handshake = System.IO.Ports.Handshake.None;
                    myserialport.RtsEnable = true;
                    myserialport.DtrEnable = true;

                    try
                    {

                        myserialport.Open();

                    }
                    catch (System.ArgumentException ex)
                    {
                        ex.Data.Clear();
                        MessageBox.Show("Please select the Valid COM port and click connect", "Error: COM Port Not Selected");
                        return;
                    }

                    this.Hide();

                }
                catch (UnauthorizedAccessException ex)
                {
                    //   MessageBox.Show(ex.Message);
                    ex.Data.Clear();
                }
                return;

            }
        }

        /**
        SerialUSBForm_Load(Object sender, EventArgs e) event gets called before this window/form 
        appears on the screen.  This reads the list of serial ports from the OS and 
        puts them in the list box (listBox1). 
                
        @param	sender	The sender of the event.
        @param	e	The arguments for the event
        <br>
        ****************************************************************************/
        private void SerialUSBForm_Load(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                string[] ArrayComPortsNames = null;
                int index = 0;
                ArrayComPortsNames = SerialPort.GetPortNames();

                while (index < ArrayComPortsNames.Length)
                {
                    listBox1.Items.Add(ArrayComPortsNames[index]);
                    index++;
                }
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }
            //listBox1.SelectedIndex = 0;\
            if (listBox1.SelectedIndex > -1)
            {
                listBox1.SelectedIndex = 0;
            }
        }

        /**
        Refresh_List_Click(Object sender, EventArgs e) event gets called when the Refresh 
        List button is clicked.  This reads the list of serial ports from the OS and 
        puts them in the list box (listBox1). This is made available to the user so he/she 
        does not need to re-run the program if a USB cable gets accidentally unplugged.
                
        @param	sender	The sender of the event.
        @param	e	The arguments for the event
        <br>
        ****************************************************************************/
        private void Refresh_List_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                string[] ArrayComPortsNames = null;
                int index = 0;
                ArrayComPortsNames = SerialPort.GetPortNames();

                while (index < ArrayComPortsNames.Length)
                {
                    listBox1.Items.Add(ArrayComPortsNames[index]);
                    index++;
                }
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }

            if (listBox1.SelectedIndex > -1)
            {
                listBox1.SelectedIndex = 0;
            }
        }
    }
}
