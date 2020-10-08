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
* @file       SplashScreen.cs
* @brief      This is the form (window) that the DS18B20 Config demo main window instantiates. 
*             This opens/appears before the main window and is standard across Maxim GUI 
*             applications for Look and Feel compliance. It appears before the main window 
*             and stays up for 3 seconds and then disappears, allowing for the other screens 
*             to load and appear.  It provides a checkbox to disable to screen in future program 
*             launches.  It also appears when the Help --> About menu item from the application's 
*             main window gets clicked.
* @version    1.0
* @notes      Dependent files and compilers:
*             1. This should be called by the main form, which is "Mainform.cs".
*             2. Compiler: Microsoft Visual Studio Professional 2017.
*****************************************************************************/
using System;
using System.Windows.Forms;

namespace MaximStyle
{
    public partial class SplashScreen : Form
    {

        private Timer timer = new Timer();
        public static int SECONDS_3 = 3;
        public bool disableCheckBoxValue = false;

        /**
        SplashScreen() is one of the multiple Constructors for the splash screen  
        form. This one takes no parameters. <br>

        @note	This method instantiates SplashScreen
        ****************************************************************************/
        public SplashScreen()
        {
            InitializeComponent();
            maximSplashScreen.DismissTime = SECONDS_3;
        }

        /**
        SplashScreen(numberOfSeconds) is one of the multiple Constructors for the serial connection 
        form. This one takes a single parameter. <br>

        @param[in] numberOfSeconds the splash screen stays on the screen before disappearing.
        @note	This method instantiates SplashScreen 
        ****************************************************************************/
        public SplashScreen(int numberOfSeconds)
        {
            InitializeComponent();
            maximSplashScreen.DismissTime = numberOfSeconds;
        }

        /**
        SplashScreen(numberOfSeconds) is one of the multiple Constructors for the serial connection 
        form. This one takes a single parameter. <br>

        @param[in] applicationName -- The name of software GUI to appear on splash screen.
        @param[in] versionString -- The version of the GUI to appear on splash screen.
        @param[in] copyrightString -- The copyright notice to appear on splash screen.
        @param[in] nonMaximCopyrightString -- Third party copyright notices to appear on splash screen.
        @param[in] numberOfSeconds -- The number of seconds the splash screen stays on the screen before disappearing.
        <br>
        @note	This method instantiates SplashScreen 
        ****************************************************************************/
        public SplashScreen(string applicationName, string versionString, string copyrightString,
            string nonMaximCopyrightString, int numberOfSeconds)
        {
            InitializeComponent();
            maximSplashScreen.DismissTime = numberOfSeconds;
            maximSplashScreen.ApplicationName = applicationName;
            maximSplashScreen.VersionString = versionString;
            maximSplashScreen.CopyrightString = copyrightString;
            maximSplashScreen.NonMaximCopyrightString = nonMaximCopyrightString;
        }

        /**
        SplashScreen_Load(Object sender, EventArgs e) event gets called before this window/form 
        appears on the screen.  It also sets up the link click event and the 
        DisableSplashScreen event.  
                
        @param	sender	The sender of the event.
        @param	e	The arguments for the event
        <br>
        ****************************************************************************/
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            maximSplashScreen.ConfigureTimer(timer, new EventHandler(timer_Tick));
            maximSplashScreen.LinkClicked = new LinkLabelLinkClickedEventHandler(LinkClicked);
            maximSplashScreen.DisableSplashScreenClicked = new EventHandler(DisableSplashScreenClicked);
            maximSplashScreen.Checked = disableCheckBoxValue;
            timer.Interval = maximSplashScreen.DismissTime * 1000;
            timer.Start();
        }
        /**
        timer_Tick(Object sender, EventArgs e) event gets called by the GUI thread 
        every time a predetermined amount of time passes.  In this case, we only 
        want one tick to occur after about 3 seconds. 
                
        @param	sender	The sender of the event.
        @param	e	The arguments for the event
        <br>
        ****************************************************************************/
        void timer_Tick(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            timer.Stop();
        }

        /**
        LinkClicked(Object sender, EventArgs e) event gets called by the GUI thread 
        of this form whenever the user clicks on the URL on the Splash Sscreen.
                
        @param	sender	The sender of the event.
        @param	e	The LinkLabelLinkClickedEventArgs arguments for the event
        <br>
        ****************************************************************************/
        void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            //linkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("http://" + linkLabel.Text);
        }

        /**
        DisableSplashScreenClicked(object sender, EventArgs e) event gets called by the GUI thread 
        whenever the DisableSplashScreen check box gets clicked. 
                
        @param	sender	The sender of the event.
        @param	e	The arguments for the event
        <br>
        ****************************************************************************/
        void DisableSplashScreenClicked(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                //MessageBox.Show("true");
                disableCheckBoxValue = maximSplashScreen.Checked;
            }
            else
            {
                //MessageBox.Show("false");
                disableCheckBoxValue = maximSplashScreen.Checked;
            }
        }

        /**
        showOKButton(bool show) is a method that gets called from the main 
        form.  The OK button on the splash screen should only show on the 
        Help --> About dialog box and not during startup. This method gives the 
        main form the ability to show or hide the button.
                
        @param[in] show -- A boolean used to show or hide the OK button.
        <br>
        ****************************************************************************/
        public void showOKButton(bool show)
        {

            if (show)
                maximButtonSplashOK.Show();
            else
                maximButtonSplashOK.Hide();
        }

        /**
        setDismissTime(int seconds) is a method that gets called from the main 
        form.  This method gives the main form the ability to set the splash 
        screen's "dismiss time".
        
        @param[in] seconds -- An integer representing the number of seconds to 
                              to show the splash screen before hiding it.
        <br>
        ****************************************************************************/
        public void setDismissTime(int seconds)
        {
            maximSplashScreen.DismissTime = seconds;
        }

        /**
        maximButtonSplashOK_Click(object sender, EventArgs e) event gets called by the GUI thread 
        whenever the splash screen's OK button gets clicked. It sets the DismissTime 
        and hides this form.
                
        @param	sender	The sender of the event.
        @param	e	The arguments for the event
        <br>
        ****************************************************************************/
        private void maximButtonSplashOK_Click(object sender, EventArgs e)
        {
            maximSplashScreen.DismissTime = SECONDS_3;
            this.Hide();
        }

        private void maximSplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
