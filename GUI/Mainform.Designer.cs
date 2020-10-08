namespace GenericGUIProject
{
   partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Dropdown_Rom_Ids = new MaximStyle.MaximComboBox();
            this.maximStatusStrip1 = new MaximStyle.MaximStatusStrip();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximGroupBoxMain = new MaximStyle.MaximGroupBox();
            this.maximGroupBox4 = new MaximStyle.MaximGroupBox();
            this.maximGroupBox7 = new MaximStyle.MaximGroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chBoxAlwaysUpdate = new MaximStyle.MaximCheckBox();
            this.btnClearScreen = new MaximStyle.MaximButton();
            this.lblDataInLength = new System.Windows.Forms.Label();
            this.chBoxAddToOldData = new MaximStyle.MaximCheckBox();
            this.maximGroupBox6 = new MaximStyle.MaximGroupBox();
            this.btnAddRead = new MaximStyle.MaximButton();
            this.maximButton1 = new MaximStyle.MaximButton();
            this.btnAddWrite = new MaximStyle.MaximButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBoxDataIn = new System.Windows.Forms.TextBox();
            this.maximGroupBox3 = new MaximStyle.MaximGroupBox();
            this.chBoxDtrEnable = new MaximStyle.MaximCheckBox();
            this.tBoxRegister = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chBoxRtsEnable = new MaximStyle.MaximCheckBox();
            this.tBoxSlave = new System.Windows.Forms.TextBox();
            this.maximGroupBox2 = new MaximStyle.MaximGroupBox();
            this.btnWrite = new MaximStyle.MaximButton();
            this.progressBarWrite = new MaximStyle.MaximHProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxByteValue = new System.Windows.Forms.TextBox();
            this.maximGroupBox1 = new MaximStyle.MaximGroupBox();
            this.progressBarRead = new MaximStyle.MaximHProgressBar();
            this.btnRead = new MaximStyle.MaximButton();
            this.tBoxNumByte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStripTop.SuspendLayout();
            this.maximGroupBoxMain.SuspendLayout();
            this.maximGroupBox4.SuspendLayout();
            this.maximGroupBox7.SuspendLayout();
            this.maximGroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.maximGroupBox3.SuspendLayout();
            this.maximGroupBox2.SuspendLayout();
            this.maximGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.SerialPort1_ErrorReceived);
            this.serialPort1.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.SerialPort1_PinChanged);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // Dropdown_Rom_Ids
            // 
            this.Dropdown_Rom_Ids.BackColor = System.Drawing.Color.White;
            this.Dropdown_Rom_Ids.DropDownHeight = 200;
            this.Dropdown_Rom_Ids.DropDownWidth = 0;
            this.Dropdown_Rom_Ids.Location = new System.Drawing.Point(0, 0);
            this.Dropdown_Rom_Ids.Name = "Dropdown_Rom_Ids";
            this.Dropdown_Rom_Ids.Size = new System.Drawing.Size(0, 0);
            this.Dropdown_Rom_Ids.TabIndex = 0;
            this.Dropdown_Rom_Ids.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Dropdown_Rom_Ids.TextAlignDropDownList = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // maximStatusStrip1
            // 
            this.maximStatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.maximStatusStrip1.Location = new System.Drawing.Point(0, 426);
            this.maximStatusStrip1.Name = "maximStatusStrip1";
            this.maximStatusStrip1.SectionsNumberOf = 3;
            this.maximStatusStrip1.SectionUseStatusProgressBar = false;
            this.maximStatusStrip1.Size = new System.Drawing.Size(902, 28);
            this.maximStatusStrip1.TabIndex = 12;
            this.maximStatusStrip1.Text = "maximStatusStrip1";
            this.maximStatusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.maximStatusStrip1_ItemClicked);
            // 
            // menuStripTop
            // 
            this.menuStripTop.BackColor = System.Drawing.Color.White;
            this.menuStripTop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.deviceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripTop.Size = new System.Drawing.Size(902, 24);
            this.menuStripTop.TabIndex = 16;
            this.menuStripTop.Text = "menuStripTop";
            this.menuStripTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripTop_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.deviceToolStripMenuItem.Text = "Device";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.ConnectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // maximGroupBoxMain
            // 
            this.maximGroupBoxMain.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBoxMain.Controls.Add(this.maximGroupBox4);
            this.maximGroupBoxMain.Controls.Add(this.maximGroupBox3);
            this.maximGroupBoxMain.Controls.Add(this.maximGroupBox2);
            this.maximGroupBoxMain.Controls.Add(this.maximGroupBox1);
            this.maximGroupBoxMain.Location = new System.Drawing.Point(0, 27);
            this.maximGroupBoxMain.Name = "maximGroupBoxMain";
            this.maximGroupBoxMain.Size = new System.Drawing.Size(898, 395);
            this.maximGroupBoxMain.TabIndex = 17;
            this.maximGroupBoxMain.TabStop = false;
            this.maximGroupBoxMain.Text = "maximGroupBox1";
            this.maximGroupBoxMain.TitleEnable = false;
            this.maximGroupBoxMain.Enter += new System.EventHandler(this.maximGroupBoxMain_Enter);
            // 
            // maximGroupBox4
            // 
            this.maximGroupBox4.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox4.Controls.Add(this.maximGroupBox7);
            this.maximGroupBox4.Controls.Add(this.maximGroupBox6);
            this.maximGroupBox4.Controls.Add(this.dataGridView1);
            this.maximGroupBox4.Controls.Add(this.tBoxDataIn);
            this.maximGroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximGroupBox4.Location = new System.Drawing.Point(278, 9);
            this.maximGroupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.maximGroupBox4.Name = "maximGroupBox4";
            this.maximGroupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.maximGroupBox4.Size = new System.Drawing.Size(613, 373);
            this.maximGroupBox4.TabIndex = 26;
            this.maximGroupBox4.TabStop = false;
            this.maximGroupBox4.Text = "Receiver Control ";
            this.maximGroupBox4.Enter += new System.EventHandler(this.maximGroupBox4_Enter);
            // 
            // maximGroupBox7
            // 
            this.maximGroupBox7.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox7.Controls.Add(this.label5);
            this.maximGroupBox7.Controls.Add(this.chBoxAlwaysUpdate);
            this.maximGroupBox7.Controls.Add(this.btnClearScreen);
            this.maximGroupBox7.Controls.Add(this.lblDataInLength);
            this.maximGroupBox7.Controls.Add(this.chBoxAddToOldData);
            this.maximGroupBox7.Location = new System.Drawing.Point(6, 243);
            this.maximGroupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.maximGroupBox7.Name = "maximGroupBox7";
            this.maximGroupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.maximGroupBox7.Size = new System.Drawing.Size(261, 119);
            this.maximGroupBox7.TabIndex = 31;
            this.maximGroupBox7.TabStop = false;
            this.maximGroupBox7.Text = "Screen Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Data Length :";
            // 
            // chBoxAlwaysUpdate
            // 
            this.chBoxAlwaysUpdate.AutoSize = true;
            this.chBoxAlwaysUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxAlwaysUpdate.Location = new System.Drawing.Point(126, 66);
            this.chBoxAlwaysUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.chBoxAlwaysUpdate.Name = "chBoxAlwaysUpdate";
            this.chBoxAlwaysUpdate.Size = new System.Drawing.Size(107, 17);
            this.chBoxAlwaysUpdate.TabIndex = 28;
            this.chBoxAlwaysUpdate.Text = "Last Byte Read";
            this.chBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            this.chBoxAlwaysUpdate.CheckedChanged += new System.EventHandler(this.chBoxAlwaysUpdate_CheckedChanged);
            // 
            // btnClearScreen
            // 
            this.btnClearScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearScreen.Location = new System.Drawing.Point(4, 35);
            this.btnClearScreen.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearScreen.Name = "btnClearScreen";
            this.btnClearScreen.Size = new System.Drawing.Size(99, 69);
            this.btnClearScreen.TabIndex = 21;
            this.btnClearScreen.Text = "Clear Screen";
            this.btnClearScreen.UseVisualStyleBackColor = true;
            this.btnClearScreen.Click += new System.EventHandler(this.btnClearScreen_Click);
            // 
            // lblDataInLength
            // 
            this.lblDataInLength.AutoSize = true;
            this.lblDataInLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInLength.Location = new System.Drawing.Point(207, 93);
            this.lblDataInLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataInLength.Name = "lblDataInLength";
            this.lblDataInLength.Size = new System.Drawing.Size(19, 13);
            this.lblDataInLength.TabIndex = 27;
            this.lblDataInLength.Text = "00";
            // 
            // chBoxAddToOldData
            // 
            this.chBoxAddToOldData.AutoSize = true;
            this.chBoxAddToOldData.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxAddToOldData.Location = new System.Drawing.Point(126, 35);
            this.chBoxAddToOldData.Margin = new System.Windows.Forms.Padding(2);
            this.chBoxAddToOldData.Name = "chBoxAddToOldData";
            this.chBoxAddToOldData.Size = new System.Drawing.Size(115, 17);
            this.chBoxAddToOldData.TabIndex = 25;
            this.chBoxAddToOldData.Text = "Add To Old Data";
            this.chBoxAddToOldData.UseVisualStyleBackColor = true;
            this.chBoxAddToOldData.CheckedChanged += new System.EventHandler(this.chBoxAddToOldData_CheckedChanged);
            // 
            // maximGroupBox6
            // 
            this.maximGroupBox6.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox6.Controls.Add(this.btnAddRead);
            this.maximGroupBox6.Controls.Add(this.maximButton1);
            this.maximGroupBox6.Controls.Add(this.btnAddWrite);
            this.maximGroupBox6.Location = new System.Drawing.Point(272, 243);
            this.maximGroupBox6.Name = "maximGroupBox6";
            this.maximGroupBox6.Size = new System.Drawing.Size(335, 119);
            this.maximGroupBox6.TabIndex = 30;
            this.maximGroupBox6.TabStop = false;
            this.maximGroupBox6.Text = "Data Grid Control";
            // 
            // btnAddRead
            // 
            this.btnAddRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRead.Location = new System.Drawing.Point(126, 77);
            this.btnAddRead.Name = "btnAddRead";
            this.btnAddRead.Size = new System.Drawing.Size(167, 31);
            this.btnAddRead.TabIndex = 1;
            this.btnAddRead.Text = "Add Read Value";
            this.btnAddRead.UseVisualStyleBackColor = true;
            this.btnAddRead.Click += new System.EventHandler(this.btnAddRead_Click);
            // 
            // maximButton1
            // 
            this.maximButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximButton1.Location = new System.Drawing.Point(6, 33);
            this.maximButton1.Name = "maximButton1";
            this.maximButton1.Size = new System.Drawing.Size(99, 75);
            this.maximButton1.TabIndex = 29;
            this.maximButton1.Text = "Clear Grid";
            this.maximButton1.UseVisualStyleBackColor = true;
            this.maximButton1.Click += new System.EventHandler(this.maximButton1_Click);
            // 
            // btnAddWrite
            // 
            this.btnAddWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWrite.Location = new System.Drawing.Point(126, 35);
            this.btnAddWrite.Name = "btnAddWrite";
            this.btnAddWrite.Size = new System.Drawing.Size(167, 30);
            this.btnAddWrite.TabIndex = 0;
            this.btnAddWrite.Text = "Add Write Value";
            this.btnAddWrite.UseVisualStyleBackColor = true;
            this.btnAddWrite.Click += new System.EventHandler(this.btnAddWrite_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.Address,
            this.Value,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(272, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(335, 192);
            this.dataGridView1.TabIndex = 29;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.Width = 70;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 70;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.Width = 70;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Status ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // tBoxDataIn
            // 
            this.tBoxDataIn.Location = new System.Drawing.Point(6, 37);
            this.tBoxDataIn.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxDataIn.Multiline = true;
            this.tBoxDataIn.Name = "tBoxDataIn";
            this.tBoxDataIn.Size = new System.Drawing.Size(261, 192);
            this.tBoxDataIn.TabIndex = 28;
            // 
            // maximGroupBox3
            // 
            this.maximGroupBox3.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox3.Controls.Add(this.chBoxDtrEnable);
            this.maximGroupBox3.Controls.Add(this.tBoxRegister);
            this.maximGroupBox3.Controls.Add(this.label4);
            this.maximGroupBox3.Controls.Add(this.label3);
            this.maximGroupBox3.Controls.Add(this.chBoxRtsEnable);
            this.maximGroupBox3.Controls.Add(this.tBoxSlave);
            this.maximGroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximGroupBox3.Location = new System.Drawing.Point(15, 241);
            this.maximGroupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.maximGroupBox3.Name = "maximGroupBox3";
            this.maximGroupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.maximGroupBox3.Size = new System.Drawing.Size(249, 141);
            this.maximGroupBox3.TabIndex = 25;
            this.maximGroupBox3.TabStop = false;
            this.maximGroupBox3.Text = "Address";
            // 
            // chBoxDtrEnable
            // 
            this.chBoxDtrEnable.AutoSize = true;
            this.chBoxDtrEnable.Checked = true;
            this.chBoxDtrEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBoxDtrEnable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxDtrEnable.Location = new System.Drawing.Point(7, 113);
            this.chBoxDtrEnable.Name = "chBoxDtrEnable";
            this.chBoxDtrEnable.Size = new System.Drawing.Size(90, 17);
            this.chBoxDtrEnable.TabIndex = 27;
            this.chBoxDtrEnable.Text = "DTR Enable ";
            this.chBoxDtrEnable.UseVisualStyleBackColor = true;
            this.chBoxDtrEnable.CheckedChanged += new System.EventHandler(this.chBoxDtrEnable_CheckedChanged);
            // 
            // tBoxRegister
            // 
            this.tBoxRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxRegister.Location = new System.Drawing.Point(129, 69);
            this.tBoxRegister.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxRegister.Name = "tBoxRegister";
            this.tBoxRegister.Size = new System.Drawing.Size(95, 20);
            this.tBoxRegister.TabIndex = 26;
            this.tBoxRegister.TextChanged += new System.EventHandler(this.tBoxRegister_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Slave Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Register Address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // chBoxRtsEnable
            // 
            this.chBoxRtsEnable.AutoSize = true;
            this.chBoxRtsEnable.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxRtsEnable.Location = new System.Drawing.Point(120, 113);
            this.chBoxRtsEnable.Margin = new System.Windows.Forms.Padding(2);
            this.chBoxRtsEnable.Name = "chBoxRtsEnable";
            this.chBoxRtsEnable.Size = new System.Drawing.Size(89, 17);
            this.chBoxRtsEnable.TabIndex = 23;
            this.chBoxRtsEnable.Text = "RTS Enable";
            this.chBoxRtsEnable.UseVisualStyleBackColor = true;
            this.chBoxRtsEnable.CheckedChanged += new System.EventHandler(this.chBoxRtsEnable_CheckedChanged_1);
            // 
            // tBoxSlave
            // 
            this.tBoxSlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSlave.Location = new System.Drawing.Point(129, 32);
            this.tBoxSlave.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxSlave.Name = "tBoxSlave";
            this.tBoxSlave.Size = new System.Drawing.Size(95, 20);
            this.tBoxSlave.TabIndex = 22;
            // 
            // maximGroupBox2
            // 
            this.maximGroupBox2.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox2.Controls.Add(this.btnWrite);
            this.maximGroupBox2.Controls.Add(this.progressBarWrite);
            this.maximGroupBox2.Controls.Add(this.label2);
            this.maximGroupBox2.Controls.Add(this.tBoxByteValue);
            this.maximGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximGroupBox2.Location = new System.Drawing.Point(15, 118);
            this.maximGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.maximGroupBox2.Name = "maximGroupBox2";
            this.maximGroupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.maximGroupBox2.Size = new System.Drawing.Size(249, 95);
            this.maximGroupBox2.TabIndex = 19;
            this.maximGroupBox2.TabStop = false;
            this.maximGroupBox2.Text = "Write";
            this.maximGroupBox2.Enter += new System.EventHandler(this.maximGroupBox2_Enter);
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(12, 53);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(2);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(84, 21);
            this.btnWrite.TabIndex = 20;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // progressBarWrite
            // 
            this.progressBarWrite.BarColor = MaximStyle.MaximHProgressBar.eColor.MaximTeal;
            this.progressBarWrite.Location = new System.Drawing.Point(186, 53);
            this.progressBarWrite.Name = "progressBarWrite";
            this.progressBarWrite.Size = new System.Drawing.Size(30, 23);
            this.progressBarWrite.TabIndex = 30;
            this.progressBarWrite.Text = "maximHProgressBar2";
            this.progressBarWrite.Value = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Byte Value";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tBoxByteValue
            // 
            this.tBoxByteValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxByteValue.Location = new System.Drawing.Point(103, 53);
            this.tBoxByteValue.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxByteValue.Name = "tBoxByteValue";
            this.tBoxByteValue.Size = new System.Drawing.Size(78, 21);
            this.tBoxByteValue.TabIndex = 21;
            this.tBoxByteValue.TextChanged += new System.EventHandler(this.tBoxByteValue_TextChanged);
            // 
            // maximGroupBox1
            // 
            this.maximGroupBox1.BackgroundColor = System.Drawing.Color.White;
            this.maximGroupBox1.Controls.Add(this.progressBarRead);
            this.maximGroupBox1.Controls.Add(this.btnRead);
            this.maximGroupBox1.Controls.Add(this.tBoxNumByte);
            this.maximGroupBox1.Controls.Add(this.label1);
            this.maximGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximGroupBox1.Location = new System.Drawing.Point(15, 9);
            this.maximGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maximGroupBox1.Name = "maximGroupBox1";
            this.maximGroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.maximGroupBox1.Size = new System.Drawing.Size(249, 94);
            this.maximGroupBox1.TabIndex = 18;
            this.maximGroupBox1.TabStop = false;
            this.maximGroupBox1.Text = "Read";
            // 
            // progressBarRead
            // 
            this.progressBarRead.BarColor = MaximStyle.MaximHProgressBar.eColor.MaximTeal;
            this.progressBarRead.Location = new System.Drawing.Point(186, 52);
            this.progressBarRead.Name = "progressBarRead";
            this.progressBarRead.Size = new System.Drawing.Size(30, 23);
            this.progressBarRead.TabIndex = 29;
            this.progressBarRead.Text = "maximHProgressBar1";
            this.progressBarRead.Value = 0;
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(11, 51);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(81, 24);
            this.btnRead.TabIndex = 18;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // tBoxNumByte
            // 
            this.tBoxNumByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxNumByte.Location = new System.Drawing.Point(103, 52);
            this.tBoxNumByte.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxNumByte.Name = "tBoxNumByte";
            this.tBoxNumByte.Size = new System.Drawing.Size(78, 21);
            this.tBoxNumByte.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Number of Byte";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 454);
            this.Controls.Add(this.maximStatusStrip1);
            this.Controls.Add(this.maximGroupBoxMain);
            this.Controls.Add(this.menuStripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mainform";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MAX32630FHTR I2C COM PORT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.Shown += new System.EventHandler(this.Mainform_Shown);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.maximGroupBoxMain.ResumeLayout(false);
            this.maximGroupBox4.ResumeLayout(false);
            this.maximGroupBox4.PerformLayout();
            this.maximGroupBox7.ResumeLayout(false);
            this.maximGroupBox7.PerformLayout();
            this.maximGroupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.maximGroupBox3.ResumeLayout(false);
            this.maximGroupBox3.PerformLayout();
            this.maximGroupBox2.ResumeLayout(false);
            this.maximGroupBox2.PerformLayout();
            this.maximGroupBox1.ResumeLayout(false);
            this.maximGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
      private System.IO.Ports.SerialPort serialPort1;
      private MaximStyle.MaximComboBox Dropdown_Rom_Ids;
      private MaximStyle.MaximStatusStrip maximStatusStrip1;
      private System.Windows.Forms.MenuStrip menuStripTop;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private MaximStyle.MaximGroupBox maximGroupBoxMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxSlave;
        private MaximStyle.MaximGroupBox maximGroupBox2;
        private MaximStyle.MaximButton btnWrite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxByteValue;
        private MaximStyle.MaximGroupBox maximGroupBox1;
        private MaximStyle.MaximButton btnRead;
        private System.Windows.Forms.TextBox tBoxNumByte;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaximStyle.MaximGroupBox maximGroupBox4;
        private System.Windows.Forms.TextBox tBoxDataIn;
        private MaximStyle.MaximButton btnClearScreen;
        private MaximStyle.MaximGroupBox maximGroupBox3;
        private System.Windows.Forms.TextBox tBoxRegister;
        private System.Windows.Forms.Label label4;
        private MaximStyle.MaximCheckBox chBoxRtsEnable;
        private MaximStyle.MaximCheckBox chBoxAddToOldData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDataInLength;
        private MaximStyle.MaximCheckBox chBoxAlwaysUpdate;
        private MaximStyle.MaximCheckBox chBoxDtrEnable;
        private MaximStyle.MaximHProgressBar progressBarWrite;
        private MaximStyle.MaximHProgressBar progressBarRead;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaximStyle.MaximButton maximButton1;
        private MaximStyle.MaximGroupBox maximGroupBox6;
        private MaximStyle.MaximButton btnAddRead;
        private MaximStyle.MaximButton btnAddWrite;
        private MaximStyle.MaximGroupBox maximGroupBox7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

