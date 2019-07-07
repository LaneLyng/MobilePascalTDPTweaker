namespace PascalTDPTweaker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openBIOS = new System.Windows.Forms.Button();
            this.saveBIOS = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.Label();
            this.board = new System.Windows.Forms.Label();
            this.textBoxBoard = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.textBoxBiosName = new System.Windows.Forms.TextBox();
            this.version = new System.Windows.Forms.Label();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxStarter = new System.Windows.Forms.TextBox();
            this.textBoxDeviceID = new System.Windows.Forms.TextBox();
            this.textBoxModifiedDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.Label();
            this.textBoxChecksum32 = new System.Windows.Forms.TextBox();
            this.checkSum = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel20 = new System.Windows.Forms.Panel();
            this.textBoxLittleEndian = new System.Windows.Forms.TextBox();
            this.littleEndian = new System.Windows.Forms.Label();
            this.bigEndian = new System.Windows.Forms.Label();
            this.textBoxBigEndian = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.textBoxDecValue = new System.Windows.Forms.TextBox();
            this.decValue = new System.Windows.Forms.Label();
            this.panelHexValue = new System.Windows.Forms.Panel();
            this.textBoxHexValue = new System.Windows.Forms.TextBox();
            this.hexValue = new System.Windows.Forms.Label();
            this.baseConverter = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxChecksum8 = new System.Windows.Forms.TextBox();
            this.cs8Fix = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cs32Fix = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.numericUpDownTargetChecksum32 = new System.Windows.Forms.NumericUpDown();
            this.targetCS = new System.Windows.Forms.Label();
            this.checksumCorrection = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.attemptBlackScreenFix = new System.Windows.Forms.Label();
            this.advancedPowerLimitsControl = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.numericUpDownP3Max = new System.Windows.Forms.NumericUpDown();
            this.panel16 = new System.Windows.Forms.Panel();
            this.numericUpDownP2Max = new System.Windows.Forms.NumericUpDown();
            this.panel19 = new System.Windows.Forms.Panel();
            this.numericUpDownP3Base = new System.Windows.Forms.NumericUpDown();
            this.panel14 = new System.Windows.Forms.Panel();
            this.numericUpDownP1Max = new System.Windows.Forms.NumericUpDown();
            this.maxPower3 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.numericUpDownP2Base = new System.Windows.Forms.NumericUpDown();
            this.defPower3 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.numericUpDownP1Base = new System.Windows.Forms.NumericUpDown();
            this.maxPower2 = new System.Windows.Forms.Label();
            this.maxPower1 = new System.Windows.Forms.Label();
            this.defPower2 = new System.Windows.Forms.Label();
            this.defPower1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.headerRemove = new System.Windows.Forms.RadioButton();
            this.headerSection = new System.Windows.Forms.Label();
            this.headerPreserve = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.basicPowerLimitsControl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.thermalLimitsControl = new System.Windows.Forms.Label();
            this.tempFixed = new System.Windows.Forms.RadioButton();
            this.tempAdjustable = new System.Windows.Forms.RadioButton();
            this.tempSlide = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.numericUpDownTemp2Max = new System.Windows.Forms.NumericUpDown();
            this.maxTemp2 = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.numericUpDownTemp2Base = new System.Windows.Forms.NumericUpDown();
            this.defTemp2 = new System.Windows.Forms.Label();
            this.minTemp2 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.numericUpDownTemp2Min = new System.Windows.Forms.NumericUpDown();
            this.panel24 = new System.Windows.Forms.Panel();
            this.numericUpDownTemp1Max = new System.Windows.Forms.NumericUpDown();
            this.minTemp1 = new System.Windows.Forms.Label();
            this.defTemp1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.numericUpDownTemp1Min = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numericUpDownTemp1Base = new System.Windows.Forms.NumericUpDown();
            this.maxTemp1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tdpFixed = new System.Windows.Forms.RadioButton();
            this.tdpAdjustable = new System.Windows.Forms.RadioButton();
            this.tdpSlide = new System.Windows.Forms.Label();
            this.baseTDP = new System.Windows.Forms.Label();
            this.maxTDP = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDownTdpMax = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDownTdpBase = new System.Windows.Forms.NumericUpDown();
            this.Adjustment = new System.Windows.Forms.TabControl();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panelHexValue.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTargetChecksum32)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP3Max)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP2Max)).BeginInit();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP3Base)).BeginInit();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP1Max)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP2Base)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP1Base)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp2Max)).BeginInit();
            this.panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp2Base)).BeginInit();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp2Min)).BeginInit();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp1Max)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp1Min)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp1Base)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTdpMax)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTdpBase)).BeginInit();
            this.Adjustment.SuspendLayout();
            this.SuspendLayout();
            // 
            // openBIOS
            // 
            this.openBIOS.Location = new System.Drawing.Point(120, 795);
            this.openBIOS.Margin = new System.Windows.Forms.Padding(2);
            this.openBIOS.Name = "openBIOS";
            this.openBIOS.Size = new System.Drawing.Size(110, 32);
            this.openBIOS.TabIndex = 0;
            this.openBIOS.Text = "Open BIOS";
            this.openBIOS.UseVisualStyleBackColor = true;
            this.openBIOS.Click += new System.EventHandler(this.OpenBIOS_Click);
            // 
            // saveBIOS
            // 
            this.saveBIOS.Location = new System.Drawing.Point(459, 795);
            this.saveBIOS.Margin = new System.Windows.Forms.Padding(2);
            this.saveBIOS.Name = "saveBIOS";
            this.saveBIOS.Size = new System.Drawing.Size(110, 32);
            this.saveBIOS.TabIndex = 2;
            this.saveBIOS.Text = "Save BIOS";
            this.saveBIOS.UseVisualStyleBackColor = true;
            this.saveBIOS.Click += new System.EventHandler(this.SaveBIOS_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxFileName.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Bold);
            this.textBoxFileName.Location = new System.Drawing.Point(148, 45);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(259, 25);
            this.textBoxFileName.TabIndex = 14;
            this.textBoxFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Bold);
            this.fileName.Location = new System.Drawing.Point(50, 50);
            this.fileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(88, 18);
            this.fileName.TabIndex = 15;
            this.fileName.Text = "Filename";
            // 
            // board
            // 
            this.board.AutoSize = true;
            this.board.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Bold);
            this.board.Location = new System.Drawing.Point(80, 148);
            this.board.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(58, 18);
            this.board.TabIndex = 17;
            this.board.Text = "Board";
            // 
            // textBoxBoard
            // 
            this.textBoxBoard.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxBoard.Location = new System.Drawing.Point(148, 146);
            this.textBoxBoard.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBoard.Name = "textBoxBoard";
            this.textBoxBoard.ReadOnly = true;
            this.textBoxBoard.Size = new System.Drawing.Size(260, 25);
            this.textBoxBoard.TabIndex = 18;
            this.textBoxBoard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(40, 18);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(98, 18);
            this.name.TabIndex = 19;
            this.name.Text = "BIOS Name";
            // 
            // textBoxBiosName
            // 
            this.textBoxBiosName.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxBiosName.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBiosName.Location = new System.Drawing.Point(148, 14);
            this.textBoxBiosName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBiosName.Name = "textBoxBiosName";
            this.textBoxBiosName.ReadOnly = true;
            this.textBoxBiosName.Size = new System.Drawing.Size(392, 25);
            this.textBoxBiosName.TabIndex = 20;
            this.textBoxBiosName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Bold);
            this.version.Location = new System.Drawing.Point(60, 116);
            this.version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(78, 18);
            this.version.TabIndex = 21;
            this.version.Text = "Version";
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxVersion.Location = new System.Drawing.Point(148, 112);
            this.textBoxVersion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.ReadOnly = true;
            this.textBoxVersion.Size = new System.Drawing.Size(259, 25);
            this.textBoxVersion.TabIndex = 22;
            this.textBoxVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Bold);
            this.date.Location = new System.Drawing.Point(88, 214);
            this.date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(48, 18);
            this.date.TabIndex = 23;
            this.date.Text = "Date";
            // 
            // textBoxDate
            // 
            this.textBoxDate.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDate.Location = new System.Drawing.Point(148, 212);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(260, 25);
            this.textBoxDate.TabIndex = 24;
            this.textBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxStarter);
            this.panel1.Controls.Add(this.textBoxDeviceID);
            this.panel1.Controls.Add(this.textBoxModifiedDate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBoxModel);
            this.panel1.Controls.Add(this.model);
            this.panel1.Controls.Add(this.textBoxChecksum32);
            this.panel1.Controls.Add(this.checkSum);
            this.panel1.Controls.Add(this.textBoxDate);
            this.panel1.Controls.Add(this.textBoxBiosName);
            this.panel1.Controls.Add(this.textBoxVersion);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.textBoxBoard);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.textBoxFileName);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.version);
            this.panel1.Controls.Add(this.fileName);
            this.panel1.Controls.Add(this.board);
            this.panel1.Location = new System.Drawing.Point(56, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 306);
            this.panel1.TabIndex = 27;
            // 
            // textBoxStarter
            // 
            this.textBoxStarter.Enabled = false;
            this.textBoxStarter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxStarter.Location = new System.Drawing.Point(416, 246);
            this.textBoxStarter.Name = "textBoxStarter";
            this.textBoxStarter.Size = new System.Drawing.Size(121, 25);
            this.textBoxStarter.TabIndex = 32;
            this.textBoxStarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDeviceID
            // 
            this.textBoxDeviceID.Enabled = false;
            this.textBoxDeviceID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBoxDeviceID.Location = new System.Drawing.Point(416, 210);
            this.textBoxDeviceID.Name = "textBoxDeviceID";
            this.textBoxDeviceID.Size = new System.Drawing.Size(121, 25);
            this.textBoxDeviceID.TabIndex = 31;
            this.textBoxDeviceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxModifiedDate
            // 
            this.textBoxModifiedDate.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxModifiedDate.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Bold);
            this.textBoxModifiedDate.Location = new System.Drawing.Point(150, 78);
            this.textBoxModifiedDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModifiedDate.Name = "textBoxModifiedDate";
            this.textBoxModifiedDate.ReadOnly = true;
            this.textBoxModifiedDate.Size = new System.Drawing.Size(258, 25);
            this.textBoxModifiedDate.TabIndex = 30;
            this.textBoxModifiedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(50, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "Modified";
            // 
            // textBoxModel
            // 
            this.textBoxModel.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxModel.Location = new System.Drawing.Point(148, 178);
            this.textBoxModel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.ReadOnly = true;
            this.textBoxModel.Size = new System.Drawing.Size(260, 25);
            this.textBoxModel.TabIndex = 28;
            this.textBoxModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Bold);
            this.model.Location = new System.Drawing.Point(80, 182);
            this.model.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(58, 18);
            this.model.TabIndex = 27;
            this.model.Text = "Model";
            // 
            // textBoxChecksum32
            // 
            this.textBoxChecksum32.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxChecksum32.Location = new System.Drawing.Point(148, 246);
            this.textBoxChecksum32.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxChecksum32.Name = "textBoxChecksum32";
            this.textBoxChecksum32.ReadOnly = true;
            this.textBoxChecksum32.Size = new System.Drawing.Size(260, 25);
            this.textBoxChecksum32.TabIndex = 26;
            this.textBoxChecksum32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkSum
            // 
            this.checkSum.AutoSize = true;
            this.checkSum.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Bold);
            this.checkSum.Location = new System.Drawing.Point(189, 278);
            this.checkSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkSum.Name = "checkSum";
            this.checkSum.Size = new System.Drawing.Size(178, 18);
            this.checkSum.TabIndex = 25;
            this.checkSum.Text = "Checksum (32 bit)";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Location = new System.Drawing.Point(416, 46);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(121, 151);
            this.panel8.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::PascalTDPTweaker.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(120, 150);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(120, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.panel20);
            this.tabPage5.Controls.Add(this.baseConverter);
            this.tabPage5.Controls.Add(this.panel11);
            this.tabPage5.Controls.Add(this.checksumCorrection);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(571, 387);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tools";
            // 
            // panel20
            // 
            this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel20.Controls.Add(this.textBoxLittleEndian);
            this.panel20.Controls.Add(this.littleEndian);
            this.panel20.Controls.Add(this.bigEndian);
            this.panel20.Controls.Add(this.textBoxBigEndian);
            this.panel20.Controls.Add(this.panel22);
            this.panel20.Controls.Add(this.decValue);
            this.panel20.Controls.Add(this.panelHexValue);
            this.panel20.Controls.Add(this.hexValue);
            this.panel20.Location = new System.Drawing.Point(-3, 226);
            this.panel20.Margin = new System.Windows.Forms.Padding(2);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(578, 160);
            this.panel20.TabIndex = 37;
            // 
            // textBoxLittleEndian
            // 
            this.textBoxLittleEndian.BackColor = System.Drawing.Color.Ivory;
            this.textBoxLittleEndian.Enabled = false;
            this.textBoxLittleEndian.Location = new System.Drawing.Point(285, 104);
            this.textBoxLittleEndian.MaxLength = 9;
            this.textBoxLittleEndian.Name = "textBoxLittleEndian";
            this.textBoxLittleEndian.Size = new System.Drawing.Size(265, 25);
            this.textBoxLittleEndian.TabIndex = 41;
            // 
            // littleEndian
            // 
            this.littleEndian.AutoSize = true;
            this.littleEndian.Location = new System.Drawing.Point(280, 82);
            this.littleEndian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.littleEndian.Name = "littleEndian";
            this.littleEndian.Size = new System.Drawing.Size(158, 18);
            this.littleEndian.TabIndex = 40;
            this.littleEndian.Text = "Little-endian: ";
            // 
            // bigEndian
            // 
            this.bigEndian.AutoSize = true;
            this.bigEndian.Location = new System.Drawing.Point(4, 82);
            this.bigEndian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bigEndian.Name = "bigEndian";
            this.bigEndian.Size = new System.Drawing.Size(128, 18);
            this.bigEndian.TabIndex = 39;
            this.bigEndian.Text = "Big-endian: ";
            // 
            // textBoxBigEndian
            // 
            this.textBoxBigEndian.BackColor = System.Drawing.Color.Ivory;
            this.textBoxBigEndian.Enabled = false;
            this.textBoxBigEndian.Location = new System.Drawing.Point(9, 104);
            this.textBoxBigEndian.MaxLength = 9;
            this.textBoxBigEndian.Name = "textBoxBigEndian";
            this.textBoxBigEndian.Size = new System.Drawing.Size(265, 25);
            this.textBoxBigEndian.TabIndex = 38;
            // 
            // panel22
            // 
            this.panel22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel22.Controls.Add(this.textBoxDecValue);
            this.panel22.Location = new System.Drawing.Point(285, 45);
            this.panel22.Margin = new System.Windows.Forms.Padding(2);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(265, 25);
            this.panel22.TabIndex = 32;
            // 
            // textBoxDecValue
            // 
            this.textBoxDecValue.BackColor = System.Drawing.Color.Ivory;
            this.textBoxDecValue.Location = new System.Drawing.Point(-2, -2);
            this.textBoxDecValue.MaxLength = 9;
            this.textBoxDecValue.Name = "textBoxDecValue";
            this.textBoxDecValue.Size = new System.Drawing.Size(265, 25);
            this.textBoxDecValue.TabIndex = 37;
            this.textBoxDecValue.TextChanged += new System.EventHandler(this.DecValueTextChanged);
            this.textBoxDecValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DecValueKeyPress);
            // 
            // decValue
            // 
            this.decValue.AutoSize = true;
            this.decValue.Location = new System.Drawing.Point(280, 21);
            this.decValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.decValue.Name = "decValue";
            this.decValue.Size = new System.Drawing.Size(148, 18);
            this.decValue.TabIndex = 32;
            this.decValue.Text = "Decimal Value:";
            // 
            // panelHexValue
            // 
            this.panelHexValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHexValue.Controls.Add(this.textBoxHexValue);
            this.panelHexValue.Location = new System.Drawing.Point(9, 45);
            this.panelHexValue.Margin = new System.Windows.Forms.Padding(2);
            this.panelHexValue.Name = "panelHexValue";
            this.panelHexValue.Size = new System.Drawing.Size(265, 25);
            this.panelHexValue.TabIndex = 31;
            // 
            // textBoxHexValue
            // 
            this.textBoxHexValue.BackColor = System.Drawing.Color.Ivory;
            this.textBoxHexValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxHexValue.Location = new System.Drawing.Point(-2, -2);
            this.textBoxHexValue.MaxLength = 8;
            this.textBoxHexValue.Name = "textBoxHexValue";
            this.textBoxHexValue.Size = new System.Drawing.Size(265, 25);
            this.textBoxHexValue.TabIndex = 36;
            this.textBoxHexValue.TextChanged += new System.EventHandler(this.HexValueTextChanged);
            this.textBoxHexValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexValueKeyPress);
            // 
            // hexValue
            // 
            this.hexValue.AutoSize = true;
            this.hexValue.Location = new System.Drawing.Point(4, 21);
            this.hexValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hexValue.Name = "hexValue";
            this.hexValue.Size = new System.Drawing.Size(188, 18);
            this.hexValue.TabIndex = 30;
            this.hexValue.Text = "Hex Value(32 bit):";
            // 
            // baseConverter
            // 
            this.baseConverter.AutoSize = true;
            this.baseConverter.Location = new System.Drawing.Point(216, 194);
            this.baseConverter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseConverter.Name = "baseConverter";
            this.baseConverter.Size = new System.Drawing.Size(148, 18);
            this.baseConverter.TabIndex = 39;
            this.baseConverter.Text = "Base Converter";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.textBoxChecksum8);
            this.panel11.Controls.Add(this.cs8Fix);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.cs32Fix);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.targetCS);
            this.panel11.Location = new System.Drawing.Point(-3, 51);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(578, 126);
            this.panel11.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(278, 105);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "* EXPERIMENTAL";
            // 
            // textBoxChecksum8
            // 
            this.textBoxChecksum8.BackColor = System.Drawing.Color.Ivory;
            this.textBoxChecksum8.Location = new System.Drawing.Point(280, 75);
            this.textBoxChecksum8.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxChecksum8.Name = "textBoxChecksum8";
            this.textBoxChecksum8.ReadOnly = true;
            this.textBoxChecksum8.Size = new System.Drawing.Size(102, 25);
            this.textBoxChecksum8.TabIndex = 33;
            this.textBoxChecksum8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cs8Fix
            // 
            this.cs8Fix.Enabled = false;
            this.cs8Fix.Location = new System.Drawing.Point(394, 70);
            this.cs8Fix.Margin = new System.Windows.Forms.Padding(2);
            this.cs8Fix.Name = "cs8Fix";
            this.cs8Fix.Size = new System.Drawing.Size(152, 32);
            this.cs8Fix.TabIndex = 34;
            this.cs8Fix.Text = "8-bit Fix";
            this.cs8Fix.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(279, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "* IN DECIMAL";
            // 
            // cs32Fix
            // 
            this.cs32Fix.Location = new System.Drawing.Point(398, 16);
            this.cs32Fix.Margin = new System.Windows.Forms.Padding(2);
            this.cs32Fix.Name = "cs32Fix";
            this.cs32Fix.Size = new System.Drawing.Size(152, 32);
            this.cs32Fix.TabIndex = 35;
            this.cs32Fix.Text = "32-bit Fix";
            this.cs32Fix.UseVisualStyleBackColor = true;
            this.cs32Fix.Click += new System.EventHandler(this.QuickFix_Click);
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Controls.Add(this.numericUpDownTargetChecksum32);
            this.panel13.Location = new System.Drawing.Point(282, 21);
            this.panel13.Margin = new System.Windows.Forms.Padding(2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(102, 25);
            this.panel13.TabIndex = 31;
            // 
            // numericUpDownTargetChecksum32
            // 
            this.numericUpDownTargetChecksum32.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownTargetChecksum32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownTargetChecksum32.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTargetChecksum32.Location = new System.Drawing.Point(-2, -2);
            this.numericUpDownTargetChecksum32.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTargetChecksum32.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownTargetChecksum32.Name = "numericUpDownTargetChecksum32";
            this.numericUpDownTargetChecksum32.Size = new System.Drawing.Size(100, 26);
            this.numericUpDownTargetChecksum32.TabIndex = 30;
            // 
            // targetCS
            // 
            this.targetCS.AutoSize = true;
            this.targetCS.Location = new System.Drawing.Point(4, 22);
            this.targetCS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.targetCS.Name = "targetCS";
            this.targetCS.Size = new System.Drawing.Size(248, 18);
            this.targetCS.TabIndex = 30;
            this.targetCS.Text = "Target Checksum(32 bit):";
            // 
            // checksumCorrection
            // 
            this.checksumCorrection.AutoSize = true;
            this.checksumCorrection.Location = new System.Drawing.Point(186, 18);
            this.checksumCorrection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checksumCorrection.Name = "checksumCorrection";
            this.checksumCorrection.Size = new System.Drawing.Size(198, 18);
            this.checksumCorrection.TabIndex = 38;
            this.checksumCorrection.Text = "Checksum Correction";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.attemptBlackScreenFix);
            this.tabPage3.Controls.Add(this.advancedPowerLimitsControl);
            this.tabPage3.Controls.Add(this.panel15);
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(571, 387);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Advanced";
            // 
            // attemptBlackScreenFix
            // 
            this.attemptBlackScreenFix.AutoSize = true;
            this.attemptBlackScreenFix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.attemptBlackScreenFix.Location = new System.Drawing.Point(166, 300);
            this.attemptBlackScreenFix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.attemptBlackScreenFix.Name = "attemptBlackScreenFix";
            this.attemptBlackScreenFix.Size = new System.Drawing.Size(248, 18);
            this.attemptBlackScreenFix.TabIndex = 38;
            this.attemptBlackScreenFix.Text = "Attempt Black Screen Fix";
            // 
            // advancedPowerLimitsControl
            // 
            this.advancedPowerLimitsControl.AutoSize = true;
            this.advancedPowerLimitsControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.advancedPowerLimitsControl.Location = new System.Drawing.Point(142, 18);
            this.advancedPowerLimitsControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.advancedPowerLimitsControl.Name = "advancedPowerLimitsControl";
            this.advancedPowerLimitsControl.Size = new System.Drawing.Size(298, 18);
            this.advancedPowerLimitsControl.TabIndex = 0;
            this.advancedPowerLimitsControl.Text = "Advanced Power Limits Control";
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel15.Controls.Add(this.panel18);
            this.panel15.Controls.Add(this.panel16);
            this.panel15.Controls.Add(this.panel19);
            this.panel15.Controls.Add(this.panel14);
            this.panel15.Controls.Add(this.maxPower3);
            this.panel15.Controls.Add(this.panel17);
            this.panel15.Controls.Add(this.defPower3);
            this.panel15.Controls.Add(this.panel12);
            this.panel15.Controls.Add(this.maxPower2);
            this.panel15.Controls.Add(this.maxPower1);
            this.panel15.Controls.Add(this.defPower2);
            this.panel15.Controls.Add(this.defPower1);
            this.panel15.Location = new System.Drawing.Point(-4, 48);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(575, 236);
            this.panel15.TabIndex = 37;
            // 
            // panel18
            // 
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel18.Controls.Add(this.numericUpDownP3Max);
            this.panel18.Location = new System.Drawing.Point(351, 197);
            this.panel18.Margin = new System.Windows.Forms.Padding(2);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(92, 24);
            this.panel18.TabIndex = 43;
            // 
            // numericUpDownP3Max
            // 
            this.numericUpDownP3Max.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownP3Max.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold);
            this.numericUpDownP3Max.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownP3Max.Location = new System.Drawing.Point(-2, -2);
            this.numericUpDownP3Max.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownP3Max.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownP3Max.Name = "numericUpDownP3Max";
            this.numericUpDownP3Max.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownP3Max.TabIndex = 31;
            // 
            // panel16
            // 
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel16.Controls.Add(this.numericUpDownP2Max);
            this.panel16.Location = new System.Drawing.Point(351, 117);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(92, 24);
            this.panel16.TabIndex = 39;
            // 
            // numericUpDownP2Max
            // 
            this.numericUpDownP2Max.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownP2Max.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold);
            this.numericUpDownP2Max.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownP2Max.Location = new System.Drawing.Point(-2, -2);
            this.numericUpDownP2Max.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownP2Max.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownP2Max.Name = "numericUpDownP2Max";
            this.numericUpDownP2Max.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownP2Max.TabIndex = 31;
            // 
            // panel19
            // 
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel19.Controls.Add(this.numericUpDownP3Base);
            this.panel19.Location = new System.Drawing.Point(351, 166);
            this.panel19.Margin = new System.Windows.Forms.Padding(2);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(92, 24);
            this.panel19.TabIndex = 41;
            // 
            // numericUpDownP3Base
            // 
            this.numericUpDownP3Base.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownP3Base.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold);
            this.numericUpDownP3Base.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownP3Base.Location = new System.Drawing.Point(-2, -2);
            this.numericUpDownP3Base.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownP3Base.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownP3Base.Name = "numericUpDownP3Base";
            this.numericUpDownP3Base.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownP3Base.TabIndex = 31;
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel14.Controls.Add(this.numericUpDownP1Max);
            this.panel14.Location = new System.Drawing.Point(351, 41);
            this.panel14.Margin = new System.Windows.Forms.Padding(2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(92, 24);
            this.panel14.TabIndex = 35;
            // 
            // numericUpDownP1Max
            // 
            this.numericUpDownP1Max.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownP1Max.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold);
            this.numericUpDownP1Max.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownP1Max.Location = new System.Drawing.Point(-2, -2);
            this.numericUpDownP1Max.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownP1Max.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownP1Max.Name = "numericUpDownP1Max";
            this.numericUpDownP1Max.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownP1Max.TabIndex = 31;
            // 
            // maxPower3
            // 
            this.maxPower3.AutoSize = true;
            this.maxPower3.Location = new System.Drawing.Point(130, 197);
            this.maxPower3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxPower3.Name = "maxPower3";
            this.maxPower3.Size = new System.Drawing.Size(148, 18);
            this.maxPower3.TabIndex = 44;
            this.maxPower3.Text = "Max Value(mW):";
            // 
            // panel17
            // 
            this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel17.Controls.Add(this.numericUpDownP2Base);
            this.panel17.Location = new System.Drawing.Point(351, 87);
            this.panel17.Margin = new System.Windows.Forms.Padding(2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(92, 24);
            this.panel17.TabIndex = 37;
            // 
            // numericUpDownP2Base
            // 
            this.numericUpDownP2Base.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownP2Base.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold);
            this.numericUpDownP2Base.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownP2Base.Location = new System.Drawing.Point(-2, -2);
            this.numericUpDownP2Base.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownP2Base.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownP2Base.Name = "numericUpDownP2Base";
            this.numericUpDownP2Base.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownP2Base.TabIndex = 31;
            // 
            // defPower3
            // 
            this.defPower3.AutoSize = true;
            this.defPower3.Location = new System.Drawing.Point(130, 166);
            this.defPower3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.defPower3.Name = "defPower3";
            this.defPower3.Size = new System.Drawing.Size(148, 18);
            this.defPower3.TabIndex = 42;
            this.defPower3.Text = "Def Value(mW):";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.numericUpDownP1Base);
            this.panel12.Location = new System.Drawing.Point(351, 12);
            this.panel12.Margin = new System.Windows.Forms.Padding(2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(92, 24);
            this.panel12.TabIndex = 33;
            // 
            // numericUpDownP1Base
            // 
            this.numericUpDownP1Base.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownP1Base.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold);
            this.numericUpDownP1Base.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownP1Base.Location = new System.Drawing.Point(-2, -2);
            this.numericUpDownP1Base.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownP1Base.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownP1Base.Name = "numericUpDownP1Base";
            this.numericUpDownP1Base.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownP1Base.TabIndex = 31;
            // 
            // maxPower2
            // 
            this.maxPower2.AutoSize = true;
            this.maxPower2.Location = new System.Drawing.Point(130, 117);
            this.maxPower2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxPower2.Name = "maxPower2";
            this.maxPower2.Size = new System.Drawing.Size(148, 18);
            this.maxPower2.TabIndex = 40;
            this.maxPower2.Text = "Max Value(mW):";
            // 
            // maxPower1
            // 
            this.maxPower1.AutoSize = true;
            this.maxPower1.Location = new System.Drawing.Point(130, 41);
            this.maxPower1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxPower1.Name = "maxPower1";
            this.maxPower1.Size = new System.Drawing.Size(148, 18);
            this.maxPower1.TabIndex = 36;
            this.maxPower1.Text = "Max Value(mW):";
            // 
            // defPower2
            // 
            this.defPower2.AutoSize = true;
            this.defPower2.Location = new System.Drawing.Point(130, 87);
            this.defPower2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.defPower2.Name = "defPower2";
            this.defPower2.Size = new System.Drawing.Size(148, 18);
            this.defPower2.TabIndex = 38;
            this.defPower2.Text = "Def Value(mW):";
            // 
            // defPower1
            // 
            this.defPower1.AutoSize = true;
            this.defPower1.Location = new System.Drawing.Point(130, 12);
            this.defPower1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.defPower1.Name = "defPower1";
            this.defPower1.Size = new System.Drawing.Size(148, 18);
            this.defPower1.TabIndex = 34;
            this.defPower1.Text = "Def Value(mW):";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.headerRemove);
            this.panel6.Controls.Add(this.headerSection);
            this.panel6.Controls.Add(this.headerPreserve);
            this.panel6.Location = new System.Drawing.Point(-4, 335);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(580, 52);
            this.panel6.TabIndex = 42;
            // 
            // headerRemove
            // 
            this.headerRemove.AutoSize = true;
            this.headerRemove.Location = new System.Drawing.Point(418, 13);
            this.headerRemove.Margin = new System.Windows.Forms.Padding(2);
            this.headerRemove.Name = "headerRemove";
            this.headerRemove.Size = new System.Drawing.Size(93, 22);
            this.headerRemove.TabIndex = 41;
            this.headerRemove.Text = "Remove";
            this.headerRemove.UseVisualStyleBackColor = true;
            // 
            // headerSection
            // 
            this.headerSection.AutoSize = true;
            this.headerSection.Location = new System.Drawing.Point(120, 15);
            this.headerSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerSection.Name = "headerSection";
            this.headerSection.Size = new System.Drawing.Size(158, 18);
            this.headerSection.TabIndex = 39;
            this.headerSection.Text = "Header Section:";
            // 
            // headerPreserve
            // 
            this.headerPreserve.AutoSize = true;
            this.headerPreserve.Location = new System.Drawing.Point(294, 13);
            this.headerPreserve.Margin = new System.Windows.Forms.Padding(2);
            this.headerPreserve.Name = "headerPreserve";
            this.headerPreserve.Size = new System.Drawing.Size(113, 22);
            this.headerPreserve.TabIndex = 40;
            this.headerPreserve.Text = "Preserve";
            this.headerPreserve.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.basicPowerLimitsControl);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(571, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            // 
            // basicPowerLimitsControl
            // 
            this.basicPowerLimitsControl.AutoSize = true;
            this.basicPowerLimitsControl.Location = new System.Drawing.Point(160, 20);
            this.basicPowerLimitsControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.basicPowerLimitsControl.Name = "basicPowerLimitsControl";
            this.basicPowerLimitsControl.Size = new System.Drawing.Size(268, 18);
            this.basicPowerLimitsControl.TabIndex = 35;
            this.basicPowerLimitsControl.Text = "Basic Power Limits Control";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Location = new System.Drawing.Point(-6, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 342);
            this.panel2.TabIndex = 33;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.thermalLimitsControl);
            this.panel9.Controls.Add(this.tempFixed);
            this.panel9.Controls.Add(this.tempAdjustable);
            this.panel9.Controls.Add(this.tempSlide);
            this.panel9.Controls.Add(this.panel27);
            this.panel9.Controls.Add(this.maxTemp2);
            this.panel9.Controls.Add(this.panel26);
            this.panel9.Controls.Add(this.defTemp2);
            this.panel9.Controls.Add(this.minTemp2);
            this.panel9.Controls.Add(this.panel25);
            this.panel9.Controls.Add(this.panel24);
            this.panel9.Controls.Add(this.minTemp1);
            this.panel9.Controls.Add(this.defTemp1);
            this.panel9.Controls.Add(this.panel7);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Controls.Add(this.maxTemp1);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(2, -2);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(574, 345);
            this.panel9.TabIndex = 29;
            // 
            // thermalLimitsControl
            // 
            this.thermalLimitsControl.AutoSize = true;
            this.thermalLimitsControl.Location = new System.Drawing.Point(88, 140);
            this.thermalLimitsControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thermalLimitsControl.Name = "thermalLimitsControl";
            this.thermalLimitsControl.Size = new System.Drawing.Size(378, 18);
            this.thermalLimitsControl.TabIndex = 36;
            this.thermalLimitsControl.Text = "Thermal Limits Control (Experimental)";
            // 
            // tempFixed
            // 
            this.tempFixed.AutoSize = true;
            this.tempFixed.Location = new System.Drawing.Point(166, 298);
            this.tempFixed.Margin = new System.Windows.Forms.Padding(2);
            this.tempFixed.Name = "tempFixed";
            this.tempFixed.Size = new System.Drawing.Size(83, 22);
            this.tempFixed.TabIndex = 60;
            this.tempFixed.Text = "Fixed";
            this.tempFixed.UseVisualStyleBackColor = true;
            // 
            // tempAdjustable
            // 
            this.tempAdjustable.AutoSize = true;
            this.tempAdjustable.Location = new System.Drawing.Point(280, 298);
            this.tempAdjustable.Margin = new System.Windows.Forms.Padding(2);
            this.tempAdjustable.Name = "tempAdjustable";
            this.tempAdjustable.Size = new System.Drawing.Size(133, 22);
            this.tempAdjustable.TabIndex = 59;
            this.tempAdjustable.Text = "Adjustable";
            this.tempAdjustable.UseVisualStyleBackColor = true;
            // 
            // tempSlide
            // 
            this.tempSlide.AutoSize = true;
            this.tempSlide.Location = new System.Drawing.Point(28, 298);
            this.tempSlide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tempSlide.Name = "tempSlide";
            this.tempSlide.Size = new System.Drawing.Size(128, 18);
            this.tempSlide.TabIndex = 58;
            this.tempSlide.Text = "Temp Slider:";
            // 
            // panel27
            // 
            this.panel27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel27.Controls.Add(this.numericUpDownTemp2Max);
            this.panel27.Location = new System.Drawing.Point(426, 260);
            this.panel27.Margin = new System.Windows.Forms.Padding(2);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(92, 24);
            this.panel27.TabIndex = 56;
            // 
            // numericUpDownTemp2Max
            // 
            this.numericUpDownTemp2Max.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownTemp2Max.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold);
            this.numericUpDownTemp2Max.Location = new System.Drawing.Point(-2, -2);
            this.numericUpDownTemp2Max.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTemp2Max.Maximum = new decimal(new int[] {
            105,
            0,
            0,
            0});
            this.numericUpDownTemp2Max.Name = "numericUpDownTemp2Max";
            this.numericUpDownTemp2Max.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownTemp2Max.TabIndex = 32;
            // 
            // maxTemp2
            // 
            this.maxTemp2.AutoSize = true;
            this.maxTemp2.Location = new System.Drawing.Point(278, 261);
            this.maxTemp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxTemp2.Name = "maxTemp2";
            this.maxTemp2.Size = new System.Drawing.Size(138, 18);
            this.maxTemp2.TabIndex = 57;
            this.maxTemp2.Text = "Max Value(C):";
            // 
            // panel26
            // 
            this.panel26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel26.Controls.Add(this.numericUpDownTemp2Base);
            this.panel26.Location = new System.Drawing.Point(426, 214);
            this.panel26.Margin = new System.Windows.Forms.Padding(2);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(92, 24);
            this.panel26.TabIndex = 54;
            // 
            // numericUpDownTemp2Base
            // 
            this.numericUpDownTemp2Base.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownTemp2Base.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold);
            this.numericUpDownTemp2Base.Location = new System.Drawing.Point(-2, -2);
            this.numericUpDownTemp2Base.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTemp2Base.Maximum = new decimal(new int[] {
            105,
            0,
            0,
            0});
            this.numericUpDownTemp2Base.Name = "numericUpDownTemp2Base";
            this.numericUpDownTemp2Base.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownTemp2Base.TabIndex = 33;
            // 
            // defTemp2
            // 
            this.defTemp2.AutoSize = true;
            this.defTemp2.Location = new System.Drawing.Point(278, 216);
            this.defTemp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.defTemp2.Name = "defTemp2";
            this.defTemp2.Size = new System.Drawing.Size(138, 18);
            this.defTemp2.TabIndex = 55;
            this.defTemp2.Text = "Def Value(C):";
            // 
            // minTemp2
            // 
            this.minTemp2.AutoSize = true;
            this.minTemp2.Location = new System.Drawing.Point(278, 172);
            this.minTemp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minTemp2.Name = "minTemp2";
            this.minTemp2.Size = new System.Drawing.Size(138, 18);
            this.minTemp2.TabIndex = 52;
            this.minTemp2.Text = "Min Value(C):";
            // 
            // panel25
            // 
            this.panel25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel25.Controls.Add(this.numericUpDownTemp2Min);
            this.panel25.Location = new System.Drawing.Point(426, 172);
            this.panel25.Margin = new System.Windows.Forms.Padding(2);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(92, 24);
            this.panel25.TabIndex = 53;
            // 
            // numericUpDownTemp2Min
            // 
            this.numericUpDownTemp2Min.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownTemp2Min.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold);
            this.numericUpDownTemp2Min.Location = new System.Drawing.Point(-2, -2);
            this.numericUpDownTemp2Min.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTemp2Min.Maximum = new decimal(new int[] {
            105,
            0,
            0,
            0});
            this.numericUpDownTemp2Min.Name = "numericUpDownTemp2Min";
            this.numericUpDownTemp2Min.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownTemp2Min.TabIndex = 34;
            // 
            // panel24
            // 
            this.panel24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel24.Controls.Add(this.numericUpDownTemp1Max);
            this.panel24.Location = new System.Drawing.Point(166, 260);
            this.panel24.Margin = new System.Windows.Forms.Padding(2);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(92, 24);
            this.panel24.TabIndex = 50;
            // 
            // numericUpDownTemp1Max
            // 
            this.numericUpDownTemp1Max.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownTemp1Max.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold);
            this.numericUpDownTemp1Max.Location = new System.Drawing.Point(-2, -2);
            this.numericUpDownTemp1Max.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTemp1Max.Maximum = new decimal(new int[] {
            105,
            0,
            0,
            0});
            this.numericUpDownTemp1Max.Name = "numericUpDownTemp1Max";
            this.numericUpDownTemp1Max.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownTemp1Max.TabIndex = 32;
            // 
            // minTemp1
            // 
            this.minTemp1.AutoSize = true;
            this.minTemp1.Location = new System.Drawing.Point(20, 172);
            this.minTemp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minTemp1.Name = "minTemp1";
            this.minTemp1.Size = new System.Drawing.Size(138, 18);
            this.minTemp1.TabIndex = 46;
            this.minTemp1.Text = "Min Value(C):";
            // 
            // defTemp1
            // 
            this.defTemp1.AutoSize = true;
            this.defTemp1.Location = new System.Drawing.Point(20, 214);
            this.defTemp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.defTemp1.Name = "defTemp1";
            this.defTemp1.Size = new System.Drawing.Size(138, 18);
            this.defTemp1.TabIndex = 47;
            this.defTemp1.Text = "Def Value(C):";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.numericUpDownTemp1Min);
            this.panel7.Location = new System.Drawing.Point(166, 172);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(92, 24);
            this.panel7.TabIndex = 51;
            // 
            // numericUpDownTemp1Min
            // 
            this.numericUpDownTemp1Min.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownTemp1Min.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold);
            this.numericUpDownTemp1Min.Location = new System.Drawing.Point(-2, -2);
            this.numericUpDownTemp1Min.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTemp1Min.Maximum = new decimal(new int[] {
            105,
            0,
            0,
            0});
            this.numericUpDownTemp1Min.Name = "numericUpDownTemp1Min";
            this.numericUpDownTemp1Min.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownTemp1Min.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.numericUpDownTemp1Base);
            this.panel5.Location = new System.Drawing.Point(166, 214);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(92, 24);
            this.panel5.TabIndex = 49;
            // 
            // numericUpDownTemp1Base
            // 
            this.numericUpDownTemp1Base.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownTemp1Base.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold);
            this.numericUpDownTemp1Base.Location = new System.Drawing.Point(-2, -2);
            this.numericUpDownTemp1Base.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTemp1Base.Maximum = new decimal(new int[] {
            105,
            0,
            0,
            0});
            this.numericUpDownTemp1Base.Name = "numericUpDownTemp1Base";
            this.numericUpDownTemp1Base.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownTemp1Base.TabIndex = 31;
            // 
            // maxTemp1
            // 
            this.maxTemp1.AutoSize = true;
            this.maxTemp1.Location = new System.Drawing.Point(20, 260);
            this.maxTemp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxTemp1.Name = "maxTemp1";
            this.maxTemp1.Size = new System.Drawing.Size(138, 18);
            this.maxTemp1.TabIndex = 48;
            this.maxTemp1.Text = "Max Value(C):";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Control;
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.tdpFixed);
            this.panel10.Controls.Add(this.tdpAdjustable);
            this.panel10.Controls.Add(this.tdpSlide);
            this.panel10.Controls.Add(this.baseTDP);
            this.panel10.Controls.Add(this.maxTDP);
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(571, 127);
            this.panel10.TabIndex = 32;
            // 
            // tdpFixed
            // 
            this.tdpFixed.AutoSize = true;
            this.tdpFixed.Location = new System.Drawing.Point(420, 75);
            this.tdpFixed.Margin = new System.Windows.Forms.Padding(2);
            this.tdpFixed.Name = "tdpFixed";
            this.tdpFixed.Size = new System.Drawing.Size(83, 22);
            this.tdpFixed.TabIndex = 2;
            this.tdpFixed.Text = "Fixed";
            this.tdpFixed.UseVisualStyleBackColor = true;
            // 
            // tdpAdjustable
            // 
            this.tdpAdjustable.AutoSize = true;
            this.tdpAdjustable.Location = new System.Drawing.Point(420, 28);
            this.tdpAdjustable.Margin = new System.Windows.Forms.Padding(2);
            this.tdpAdjustable.Name = "tdpAdjustable";
            this.tdpAdjustable.Size = new System.Drawing.Size(133, 22);
            this.tdpAdjustable.TabIndex = 1;
            this.tdpAdjustable.Text = "Adjustable";
            this.tdpAdjustable.UseVisualStyleBackColor = true;
            // 
            // tdpSlide
            // 
            this.tdpSlide.AutoSize = true;
            this.tdpSlide.Location = new System.Drawing.Point(276, 30);
            this.tdpSlide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tdpSlide.Name = "tdpSlide";
            this.tdpSlide.Size = new System.Drawing.Size(138, 18);
            this.tdpSlide.TabIndex = 0;
            this.tdpSlide.Text = "Power Slider:";
            // 
            // baseTDP
            // 
            this.baseTDP.AutoSize = true;
            this.baseTDP.Location = new System.Drawing.Point(16, 30);
            this.baseTDP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseTDP.Name = "baseTDP";
            this.baseTDP.Size = new System.Drawing.Size(118, 18);
            this.baseTDP.TabIndex = 5;
            this.baseTDP.Text = "Target(mW):";
            // 
            // maxTDP
            // 
            this.maxTDP.AutoSize = true;
            this.maxTDP.Location = new System.Drawing.Point(16, 76);
            this.maxTDP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxTDP.Name = "maxTDP";
            this.maxTDP.Size = new System.Drawing.Size(108, 18);
            this.maxTDP.TabIndex = 6;
            this.maxTDP.Text = "Limit(mW):";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.numericUpDownTdpMax);
            this.panel4.Location = new System.Drawing.Point(164, 76);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(92, 24);
            this.panel4.TabIndex = 1;
            // 
            // numericUpDownTdpMax
            // 
            this.numericUpDownTdpMax.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownTdpMax.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold);
            this.numericUpDownTdpMax.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTdpMax.Location = new System.Drawing.Point(-2, -3);
            this.numericUpDownTdpMax.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTdpMax.Maximum = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            this.numericUpDownTdpMax.Name = "numericUpDownTdpMax";
            this.numericUpDownTdpMax.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownTdpMax.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.numericUpDownTdpBase);
            this.panel3.Location = new System.Drawing.Point(164, 28);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 24);
            this.panel3.TabIndex = 0;
            // 
            // numericUpDownTdpBase
            // 
            this.numericUpDownTdpBase.BackColor = System.Drawing.Color.Ivory;
            this.numericUpDownTdpBase.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTdpBase.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTdpBase.Location = new System.Drawing.Point(-2, -2);
            this.numericUpDownTdpBase.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTdpBase.Maximum = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            this.numericUpDownTdpBase.Name = "numericUpDownTdpBase";
            this.numericUpDownTdpBase.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownTdpBase.TabIndex = 29;
            // 
            // Adjustment
            // 
            this.Adjustment.Controls.Add(this.tabPage1);
            this.Adjustment.Controls.Add(this.tabPage3);
            this.Adjustment.Controls.Add(this.tabPage5);
            this.Adjustment.Location = new System.Drawing.Point(56, 354);
            this.Adjustment.Margin = new System.Windows.Forms.Padding(2);
            this.Adjustment.Name = "Adjustment";
            this.Adjustment.SelectedIndex = 0;
            this.Adjustment.Size = new System.Drawing.Size(579, 418);
            this.Adjustment.TabIndex = 33;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 795);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 32);
            this.button2.TabIndex = 34;
            this.button2.Text = "Preset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Preset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(678, 843);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Adjustment);
            this.Controls.Add(this.saveBIOS);
            this.Controls.Add(this.openBIOS);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 7.875F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(700, 899);
            this.MinimumSize = new System.Drawing.Size(700, 899);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile Pascal TDP Tweaker v1.21";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panelHexValue.ResumeLayout(false);
            this.panelHexValue.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTargetChecksum32)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP3Max)).EndInit();
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP2Max)).EndInit();
            this.panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP3Base)).EndInit();
            this.panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP1Max)).EndInit();
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP2Base)).EndInit();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP1Base)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp2Max)).EndInit();
            this.panel26.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp2Base)).EndInit();
            this.panel25.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp2Min)).EndInit();
            this.panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp1Max)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp1Min)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp1Base)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTdpMax)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTdpBase)).EndInit();
            this.Adjustment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openBIOS;
        private System.Windows.Forms.Button saveBIOS;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label board;
        private System.Windows.Forms.TextBox textBoxBoard;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBoxBiosName;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxChecksum32;
        private System.Windows.Forms.Label checkSum;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxModifiedDate;
        private System.Windows.Forms.TextBox textBoxStarter;
        private System.Windows.Forms.TextBox textBoxDeviceID;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox textBoxLittleEndian;
        private System.Windows.Forms.Label littleEndian;
        private System.Windows.Forms.Label bigEndian;
        private System.Windows.Forms.TextBox textBoxBigEndian;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox textBoxDecValue;
        private System.Windows.Forms.Label decValue;
        private System.Windows.Forms.Panel panelHexValue;
        private System.Windows.Forms.TextBox textBoxHexValue;
        private System.Windows.Forms.Label hexValue;
        private System.Windows.Forms.Label baseConverter;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox textBoxChecksum8;
        private System.Windows.Forms.Button cs8Fix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cs32Fix;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.NumericUpDown numericUpDownTargetChecksum32;
        private System.Windows.Forms.Label targetCS;
        private System.Windows.Forms.Label checksumCorrection;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label advancedPowerLimitsControl;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.NumericUpDown numericUpDownP3Max;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.NumericUpDown numericUpDownP2Max;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.NumericUpDown numericUpDownP3Base;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.NumericUpDown numericUpDownP1Max;
        private System.Windows.Forms.Label maxPower3;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.NumericUpDown numericUpDownP2Base;
        private System.Windows.Forms.Label defPower3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.NumericUpDown numericUpDownP1Base;
        private System.Windows.Forms.Label maxPower2;
        private System.Windows.Forms.Label maxPower1;
        private System.Windows.Forms.Label defPower2;
        private System.Windows.Forms.Label defPower1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label thermalLimitsControl;
        private System.Windows.Forms.Label basicPowerLimitsControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.NumericUpDown numericUpDownTemp2Max;
        private System.Windows.Forms.RadioButton tempFixed;
        private System.Windows.Forms.RadioButton tempAdjustable;
        private System.Windows.Forms.Label tempSlide;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Label maxTemp2;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.NumericUpDown numericUpDownTemp2Base;
        private System.Windows.Forms.Label defTemp2;
        private System.Windows.Forms.Label minTemp2;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.NumericUpDown numericUpDownTemp2Min;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.NumericUpDown numericUpDownTemp1Max;
        private System.Windows.Forms.Label minTemp1;
        private System.Windows.Forms.Label defTemp1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown numericUpDownTemp1Min;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown numericUpDownTemp1Base;
        private System.Windows.Forms.Label maxTemp1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton tdpFixed;
        private System.Windows.Forms.RadioButton tdpAdjustable;
        private System.Windows.Forms.Label tdpSlide;
        private System.Windows.Forms.Label baseTDP;
        private System.Windows.Forms.Label maxTDP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericUpDownTdpMax;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDownTdpBase;
        private System.Windows.Forms.TabControl Adjustment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label attemptBlackScreenFix;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton headerRemove;
        private System.Windows.Forms.Label headerSection;
        private System.Windows.Forms.RadioButton headerPreserve;
    }
}

