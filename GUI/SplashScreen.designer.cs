namespace MaximStyle
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maximSplashScreen = new MaximStyle.MaximSplashScreen();
            this.maximButtonSplashOK = new MaximStyle.MaximButton();
            this.SuspendLayout();
            // 
            // maximSplashScreen
            // 
            this.maximSplashScreen.ApplicationIconImage = null;
            this.maximSplashScreen.ApplicationName = "MAX32630FTHR I2C COM PORT ";
            this.maximSplashScreen.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.maximSplashScreen.BackColor = System.Drawing.Color.White;
            this.maximSplashScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maximSplashScreen.Checked = false;
            this.maximSplashScreen.CopyrightString = "© Maxim Integrated Products, Inc.";
            this.maximSplashScreen.Cursor = System.Windows.Forms.Cursors.Default;
            this.maximSplashScreen.Font = new System.Drawing.Font("Arial", 11F);
            this.maximSplashScreen.Location = new System.Drawing.Point(0, 0);
            this.maximSplashScreen.Margin = new System.Windows.Forms.Padding(4);
            this.maximSplashScreen.Name = "maximSplashScreen";
            this.maximSplashScreen.NonMaximCopyrightString = "";
            this.maximSplashScreen.Size = new System.Drawing.Size(400, 320);
            this.maximSplashScreen.TabIndex = 0;
            this.maximSplashScreen.VersionString = "Version 1.0";
            this.maximSplashScreen.Load += new System.EventHandler(this.maximSplashScreen_Load);
            // 
            // maximButtonSplashOK
            // 
            this.maximButtonSplashOK.Location = new System.Drawing.Point(287, 285);
            this.maximButtonSplashOK.Name = "maximButtonSplashOK";
            this.maximButtonSplashOK.Size = new System.Drawing.Size(75, 23);
            this.maximButtonSplashOK.TabIndex = 1;
            this.maximButtonSplashOK.Text = "&OK";
            this.maximButtonSplashOK.UseVisualStyleBackColor = true;
            this.maximButtonSplashOK.Click += new System.EventHandler(this.maximButtonSplashOK_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.ControlBox = false;
            this.Controls.Add(this.maximButtonSplashOK);
            this.Controls.Add(this.maximSplashScreen);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaximStyle.MaximSplashScreen maximSplashScreen;
        private MaximButton maximButtonSplashOK;
    }
}