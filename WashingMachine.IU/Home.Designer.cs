namespace WashingMachine.IU
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewMachine = new System.Windows.Forms.Button();
            this.labelShowMachine = new System.Windows.Forms.Label();
            this.MachineContainer = new System.Windows.Forms.Panel();
            this.SpinnerLoadingContainer = new System.Windows.Forms.Panel();
            this.SpinnerLoading = new System.Windows.Forms.PictureBox();
            this.publicity = new System.Windows.Forms.PictureBox();
            this.ControlsSystem = new System.Windows.Forms.Panel();
            this.TimePanel = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.BtnLoadTime = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnCancelTime = new System.Windows.Forms.Button();
            this.btnStopFilling = new System.Windows.Forms.Button();
            this.panelLoadClothes = new System.Windows.Forms.Panel();
            this.panelTypeOfClothing = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFilling = new System.Windows.Forms.Label();
            this.DecoratorPanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.WashingTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TypeClothing = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.lblDetergent = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loadDetergent = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnDry = new System.Windows.Forms.Button();
            this.btnSpecifyTime = new System.Windows.Forms.Button();
            this.btnLoadClothe = new System.Windows.Forms.Button();
            this.btnLoadWater = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TurnON = new System.Windows.Forms.Button();
            this.TurnOFF = new System.Windows.Forms.Button();
            this.lblWater = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRealTime = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.SerialNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stateInWhichItIs = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.MachineContainer.SuspendLayout();
            this.SpinnerLoadingContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicity)).BeginInit();
            this.ControlsSystem.SuspendLayout();
            this.TimePanel.SuspendLayout();
            this.panelLoadClothes.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 70);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnClose.Location = new System.Drawing.Point(1028, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 24);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Washing-Machine Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(227)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(66, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loading";
            // 
            // btnAddNewMachine
            // 
            this.btnAddNewMachine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddNewMachine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewMachine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddNewMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewMachine.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMachine.ForeColor = System.Drawing.Color.White;
            this.btnAddNewMachine.Location = new System.Drawing.Point(29, 96);
            this.btnAddNewMachine.Name = "btnAddNewMachine";
            this.btnAddNewMachine.Size = new System.Drawing.Size(143, 32);
            this.btnAddNewMachine.TabIndex = 3;
            this.btnAddNewMachine.Text = "+ Add new";
            this.btnAddNewMachine.UseVisualStyleBackColor = true;
            this.btnAddNewMachine.Click += new System.EventHandler(this.btnAddNewMachine_Click);
            // 
            // labelShowMachine
            // 
            this.labelShowMachine.AutoSize = true;
            this.labelShowMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelShowMachine.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowMachine.ForeColor = System.Drawing.Color.White;
            this.labelShowMachine.Location = new System.Drawing.Point(26, 167);
            this.labelShowMachine.Name = "labelShowMachine";
            this.labelShowMachine.Size = new System.Drawing.Size(178, 17);
            this.labelShowMachine.TabIndex = 4;
            this.labelShowMachine.Text = "Washine-machine created";
            // 
            // MachineContainer
            // 
            this.MachineContainer.AutoScroll = true;
            this.MachineContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MachineContainer.Controls.Add(this.SpinnerLoadingContainer);
            this.MachineContainer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MachineContainer.Location = new System.Drawing.Point(29, 193);
            this.MachineContainer.Name = "MachineContainer";
            this.MachineContainer.Size = new System.Drawing.Size(234, 299);
            this.MachineContainer.TabIndex = 5;
            // 
            // SpinnerLoadingContainer
            // 
            this.SpinnerLoadingContainer.Controls.Add(this.label2);
            this.SpinnerLoadingContainer.Controls.Add(this.SpinnerLoading);
            this.SpinnerLoadingContainer.Location = new System.Drawing.Point(26, 72);
            this.SpinnerLoadingContainer.Name = "SpinnerLoadingContainer";
            this.SpinnerLoadingContainer.Size = new System.Drawing.Size(177, 142);
            this.SpinnerLoadingContainer.TabIndex = 7;
            this.SpinnerLoadingContainer.Visible = false;
            // 
            // SpinnerLoading
            // 
            this.SpinnerLoading.BackColor = System.Drawing.Color.Transparent;
            this.SpinnerLoading.Image = ((System.Drawing.Image)(resources.GetObject("SpinnerLoading.Image")));
            this.SpinnerLoading.Location = new System.Drawing.Point(14, 13);
            this.SpinnerLoading.Name = "SpinnerLoading";
            this.SpinnerLoading.Size = new System.Drawing.Size(147, 112);
            this.SpinnerLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SpinnerLoading.TabIndex = 0;
            this.SpinnerLoading.TabStop = false;
            // 
            // publicity
            // 
            this.publicity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.publicity.Image = ((System.Drawing.Image)(resources.GetObject("publicity.Image")));
            this.publicity.Location = new System.Drawing.Point(307, 78);
            this.publicity.Name = "publicity";
            this.publicity.Size = new System.Drawing.Size(732, 475);
            this.publicity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.publicity.TabIndex = 6;
            this.publicity.TabStop = false;
            // 
            // ControlsSystem
            // 
            this.ControlsSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ControlsSystem.Controls.Add(this.TimePanel);
            this.ControlsSystem.Controls.Add(this.btnStopFilling);
            this.ControlsSystem.Controls.Add(this.panelLoadClothes);
            this.ControlsSystem.Controls.Add(this.lblFilling);
            this.ControlsSystem.Controls.Add(this.DecoratorPanel);
            this.ControlsSystem.Controls.Add(this.label14);
            this.ControlsSystem.Controls.Add(this.WashingTime);
            this.ControlsSystem.Controls.Add(this.label11);
            this.ControlsSystem.Controls.Add(this.TypeClothing);
            this.ControlsSystem.Controls.Add(this.label9);
            this.ControlsSystem.Controls.Add(this.lblPause);
            this.ControlsSystem.Controls.Add(this.lblDetergent);
            this.ControlsSystem.Controls.Add(this.label7);
            this.ControlsSystem.Controls.Add(this.loadDetergent);
            this.ControlsSystem.Controls.Add(this.btnPause);
            this.ControlsSystem.Controls.Add(this.btnDry);
            this.ControlsSystem.Controls.Add(this.btnSpecifyTime);
            this.ControlsSystem.Controls.Add(this.btnLoadClothe);
            this.ControlsSystem.Controls.Add(this.btnLoadWater);
            this.ControlsSystem.Controls.Add(this.flowLayoutPanel1);
            this.ControlsSystem.Controls.Add(this.lblWater);
            this.ControlsSystem.Controls.Add(this.label4);
            this.ControlsSystem.Controls.Add(this.lblRealTime);
            this.ControlsSystem.Controls.Add(this.lblTimer);
            this.ControlsSystem.Controls.Add(this.SerialNumber);
            this.ControlsSystem.Controls.Add(this.label3);
            this.ControlsSystem.Controls.Add(this.stateInWhichItIs);
            this.ControlsSystem.Location = new System.Drawing.Point(304, 78);
            this.ControlsSystem.Name = "ControlsSystem";
            this.ControlsSystem.Size = new System.Drawing.Size(735, 475);
            this.ControlsSystem.TabIndex = 7;
            // 
            // TimePanel
            // 
            this.TimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimePanel.Controls.Add(this.label12);
            this.TimePanel.Controls.Add(this.label10);
            this.TimePanel.Controls.Add(this.txtSeconds);
            this.TimePanel.Controls.Add(this.label6);
            this.TimePanel.Controls.Add(this.label5);
            this.TimePanel.Controls.Add(this.txtMinutes);
            this.TimePanel.Controls.Add(this.BtnLoadTime);
            this.TimePanel.Controls.Add(this.panel4);
            this.TimePanel.Controls.Add(this.label16);
            this.TimePanel.Controls.Add(this.BtnCancelTime);
            this.TimePanel.Location = new System.Drawing.Point(248, 136);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.Size = new System.Drawing.Size(373, 294);
            this.TimePanel.TabIndex = 32;
            this.TimePanel.Visible = false;
            // 
            // label12
            // 
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(181, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 19);
            this.label12.TabIndex = 37;
            this.label12.Text = "Seconds";
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(22, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "Minutes";
            // 
            // txtSeconds
            // 
            this.txtSeconds.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeconds.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeconds.Location = new System.Drawing.Point(181, 180);
            this.txtSeconds.MaxLength = 2;
            this.txtSeconds.Multiline = true;
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(144, 30);
            this.txtSeconds.TabIndex = 35;
            this.txtSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterSeconds);
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 65);
            this.label6.TabIndex = 34;
            this.label6.Text = "Minimum washing time depending on clothes:\r\nClean: 1 min                   Slight" +
    "ly dirty: 3 min\r\nVery dirty: 10 min              Dirty: 6 min\r\n";
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 32);
            this.label5.TabIndex = 33;
            this.label5.Text = "Before starting to wash, make sure you enter enough time for the clothes to be cl" +
    "ean.";
            // 
            // txtMinutes
            // 
            this.txtMinutes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinutes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutes.Location = new System.Drawing.Point(23, 180);
            this.txtMinutes.Multiline = true;
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(142, 30);
            this.txtMinutes.TabIndex = 32;
            this.txtMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterMinutes);
            // 
            // BtnLoadTime
            // 
            this.BtnLoadTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadTime.ForeColor = System.Drawing.Color.White;
            this.BtnLoadTime.Location = new System.Drawing.Point(23, 241);
            this.BtnLoadTime.Name = "BtnLoadTime";
            this.BtnLoadTime.Size = new System.Drawing.Size(142, 28);
            this.BtnLoadTime.TabIndex = 25;
            this.BtnLoadTime.Text = "Start washing";
            this.BtnLoadTime.UseVisualStyleBackColor = true;
            this.BtnLoadTime.Click += new System.EventHandler(this.BtnLoadTime_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(23, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 1);
            this.panel4.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(19, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 20);
            this.label16.TabIndex = 25;
            this.label16.Text = "Enter the time";
            // 
            // BtnCancelTime
            // 
            this.BtnCancelTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelTime.ForeColor = System.Drawing.Color.White;
            this.BtnCancelTime.Location = new System.Drawing.Point(181, 240);
            this.BtnCancelTime.Name = "BtnCancelTime";
            this.BtnCancelTime.Size = new System.Drawing.Size(144, 28);
            this.BtnCancelTime.TabIndex = 26;
            this.BtnCancelTime.Text = "Cancel";
            this.BtnCancelTime.UseVisualStyleBackColor = true;
            this.BtnCancelTime.Click += new System.EventHandler(this.BtnCancelTime_Click);
            // 
            // btnStopFilling
            // 
            this.btnStopFilling.BackColor = System.Drawing.Color.Transparent;
            this.btnStopFilling.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnStopFilling.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStopFilling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStopFilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopFilling.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopFilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.btnStopFilling.Location = new System.Drawing.Point(674, 24);
            this.btnStopFilling.Name = "btnStopFilling";
            this.btnStopFilling.Size = new System.Drawing.Size(43, 26);
            this.btnStopFilling.TabIndex = 8;
            this.btnStopFilling.Text = "Stop";
            this.btnStopFilling.UseVisualStyleBackColor = false;
            this.btnStopFilling.Visible = false;
            this.btnStopFilling.Click += new System.EventHandler(this.btnStopFilling_Click);
            // 
            // panelLoadClothes
            // 
            this.panelLoadClothes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLoadClothes.Controls.Add(this.panelTypeOfClothing);
            this.panelLoadClothes.Controls.Add(this.btnAccept);
            this.panelLoadClothes.Controls.Add(this.panel2);
            this.panelLoadClothes.Controls.Add(this.label8);
            this.panelLoadClothes.Controls.Add(this.btnCancel);
            this.panelLoadClothes.Location = new System.Drawing.Point(262, 151);
            this.panelLoadClothes.Name = "panelLoadClothes";
            this.panelLoadClothes.Size = new System.Drawing.Size(348, 284);
            this.panelLoadClothes.TabIndex = 24;
            this.panelLoadClothes.Visible = false;
            // 
            // panelTypeOfClothing
            // 
            this.panelTypeOfClothing.Location = new System.Drawing.Point(25, 56);
            this.panelTypeOfClothing.Name = "panelTypeOfClothing";
            this.panelTypeOfClothing.Size = new System.Drawing.Size(300, 156);
            this.panelTypeOfClothing.TabIndex = 33;
            // 
            // btnAccept
            // 
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(23, 237);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(114, 28);
            this.btnAccept.TabIndex = 25;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(23, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 1);
            this.panel2.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Select your type of clothes";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(211, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 28);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFilling
            // 
            this.lblFilling.AutoSize = true;
            this.lblFilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFilling.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.lblFilling.Location = new System.Drawing.Point(625, 8);
            this.lblFilling.Name = "lblFilling";
            this.lblFilling.Size = new System.Drawing.Size(35, 16);
            this.lblFilling.TabIndex = 31;
            this.lblFilling.Text = "Filling";
            this.lblFilling.Visible = false;
            // 
            // DecoratorPanel
            // 
            this.DecoratorPanel.BackColor = System.Drawing.Color.White;
            this.DecoratorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DecoratorPanel.Location = new System.Drawing.Point(0, 0);
            this.DecoratorPanel.Name = "DecoratorPanel";
            this.DecoratorPanel.Size = new System.Drawing.Size(735, 1);
            this.DecoratorPanel.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(263, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(238, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "State of clothes in washing time";
            // 
            // WashingTime
            // 
            this.WashingTime.AutoSize = true;
            this.WashingTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WashingTime.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WashingTime.ForeColor = System.Drawing.Color.White;
            this.WashingTime.Location = new System.Drawing.Point(306, 285);
            this.WashingTime.Name = "WashingTime";
            this.WashingTime.Size = new System.Drawing.Size(36, 16);
            this.WashingTime.TabIndex = 27;
            this.WashingTime.Text = "0 min";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(261, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Estimated time:";
            // 
            // TypeClothing
            // 
            this.TypeClothing.AutoSize = true;
            this.TypeClothing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeClothing.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeClothing.ForeColor = System.Drawing.Color.White;
            this.TypeClothing.Location = new System.Drawing.Point(306, 228);
            this.TypeClothing.Name = "TypeClothing";
            this.TypeClothing.Size = new System.Drawing.Size(234, 16);
            this.TypeClothing.TabIndex = 25;
            this.TypeClothing.Text = "You have not loaded the type of clothing";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(261, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Type of clothes loaded:";
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPause.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.lblPause.Location = new System.Drawing.Point(428, 10);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(33, 13);
            this.lblPause.TabIndex = 23;
            this.lblPause.Text = "Pause";
            this.lblPause.Visible = false;
            // 
            // lblDetergent
            // 
            this.lblDetergent.AutoSize = true;
            this.lblDetergent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDetergent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetergent.ForeColor = System.Drawing.Color.White;
            this.lblDetergent.Location = new System.Drawing.Point(413, 94);
            this.lblDetergent.Name = "lblDetergent";
            this.lblDetergent.Size = new System.Drawing.Size(103, 17);
            this.lblDetergent.TabIndex = 22;
            this.lblDetergent.Text = "Does not have";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label7.Location = new System.Drawing.Point(346, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Detergent";
            // 
            // loadDetergent
            // 
            this.loadDetergent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadDetergent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadDetergent.ForeColor = System.Drawing.Color.White;
            this.loadDetergent.Location = new System.Drawing.Point(36, 275);
            this.loadDetergent.Name = "loadDetergent";
            this.loadDetergent.Size = new System.Drawing.Size(143, 28);
            this.loadDetergent.TabIndex = 20;
            this.loadDetergent.Text = "Load detergent";
            this.loadDetergent.UseVisualStyleBackColor = true;
            this.loadDetergent.Click += new System.EventHandler(this.loadDetergent_Click);
            // 
            // btnPause
            // 
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(36, 381);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(143, 28);
            this.btnPause.TabIndex = 19;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnDry
            // 
            this.btnDry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDry.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDry.ForeColor = System.Drawing.Color.White;
            this.btnDry.Location = new System.Drawing.Point(36, 345);
            this.btnDry.Name = "btnDry";
            this.btnDry.Size = new System.Drawing.Size(143, 28);
            this.btnDry.TabIndex = 18;
            this.btnDry.Text = "Dry";
            this.btnDry.UseVisualStyleBackColor = true;
            this.btnDry.Click += new System.EventHandler(this.btnDry_Click);
            // 
            // btnSpecifyTime
            // 
            this.btnSpecifyTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecifyTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecifyTime.ForeColor = System.Drawing.Color.White;
            this.btnSpecifyTime.Location = new System.Drawing.Point(36, 309);
            this.btnSpecifyTime.Name = "btnSpecifyTime";
            this.btnSpecifyTime.Size = new System.Drawing.Size(143, 28);
            this.btnSpecifyTime.TabIndex = 17;
            this.btnSpecifyTime.Text = "Specify time";
            this.btnSpecifyTime.UseVisualStyleBackColor = true;
            this.btnSpecifyTime.Click += new System.EventHandler(this.btnSpecifyTime_Click);
            // 
            // btnLoadClothe
            // 
            this.btnLoadClothe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadClothe.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadClothe.ForeColor = System.Drawing.Color.White;
            this.btnLoadClothe.Location = new System.Drawing.Point(36, 241);
            this.btnLoadClothe.Name = "btnLoadClothe";
            this.btnLoadClothe.Size = new System.Drawing.Size(143, 28);
            this.btnLoadClothe.TabIndex = 16;
            this.btnLoadClothe.Text = "Load clothe";
            this.btnLoadClothe.UseVisualStyleBackColor = true;
            this.btnLoadClothe.Click += new System.EventHandler(this.btnLoadClothe_Click);
            // 
            // btnLoadWater
            // 
            this.btnLoadWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadWater.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadWater.ForeColor = System.Drawing.Color.White;
            this.btnLoadWater.Location = new System.Drawing.Point(36, 204);
            this.btnLoadWater.Name = "btnLoadWater";
            this.btnLoadWater.Size = new System.Drawing.Size(143, 28);
            this.btnLoadWater.TabIndex = 8;
            this.btnLoadWater.Text = "Load water";
            this.btnLoadWater.UseVisualStyleBackColor = true;
            this.btnLoadWater.Click += new System.EventHandler(this.btnLoadWater_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TurnON);
            this.flowLayoutPanel1.Controls.Add(this.TurnOFF);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(202, 57);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // TurnON
            // 
            this.TurnON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TurnON.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnON.ForeColor = System.Drawing.Color.White;
            this.TurnON.Location = new System.Drawing.Point(3, 3);
            this.TurnON.Name = "TurnON";
            this.TurnON.Size = new System.Drawing.Size(95, 48);
            this.TurnON.TabIndex = 0;
            this.TurnON.Text = "ON";
            this.TurnON.UseVisualStyleBackColor = true;
            this.TurnON.Click += new System.EventHandler(this.TurnON_Click);
            // 
            // TurnOFF
            // 
            this.TurnOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TurnOFF.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnOFF.ForeColor = System.Drawing.Color.White;
            this.TurnOFF.Location = new System.Drawing.Point(104, 3);
            this.TurnOFF.Name = "TurnOFF";
            this.TurnOFF.Size = new System.Drawing.Size(95, 48);
            this.TurnOFF.TabIndex = 1;
            this.TurnOFF.Text = "OFF";
            this.TurnOFF.UseVisualStyleBackColor = true;
            this.TurnOFF.Click += new System.EventHandler(this.TurnOFF_Click);
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWater.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWater.ForeColor = System.Drawing.Color.White;
            this.lblWater.Location = new System.Drawing.Point(623, 25);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(29, 20);
            this.lblWater.TabIndex = 13;
            this.lblWater.Text = "0%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.label4.Location = new System.Drawing.Point(549, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Water:";
            // 
            // lblRealTime
            // 
            this.lblRealTime.AutoSize = true;
            this.lblRealTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRealTime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealTime.ForeColor = System.Drawing.Color.White;
            this.lblRealTime.Location = new System.Drawing.Point(412, 26);
            this.lblRealTime.Name = "lblRealTime";
            this.lblRealTime.Size = new System.Drawing.Size(65, 20);
            this.lblRealTime.TabIndex = 11;
            this.lblRealTime.Text = "00:00:00";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.lblTimer.Location = new System.Drawing.Point(346, 18);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(66, 22);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "Timer: ";
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSize = true;
            this.SerialNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SerialNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNumber.ForeColor = System.Drawing.Color.White;
            this.SerialNumber.Location = new System.Drawing.Point(29, 39);
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.Size = new System.Drawing.Size(244, 20);
            this.SerialNumber.TabIndex = 9;
            this.SerialNumber.Text = "Washing-machine Serial Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selected Washine-machine";
            // 
            // stateInWhichItIs
            // 
            this.stateInWhichItIs.AutoSize = true;
            this.stateInWhichItIs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stateInWhichItIs.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateInWhichItIs.ForeColor = System.Drawing.Color.White;
            this.stateInWhichItIs.Location = new System.Drawing.Point(308, 341);
            this.stateInWhichItIs.Name = "stateInWhichItIs";
            this.stateInWhichItIs.Size = new System.Drawing.Size(36, 16);
            this.stateInWhichItIs.TabIndex = 29;
            this.stateInWhichItIs.Text = "none";
            // 
            // Home
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1054, 565);
            this.Controls.Add(this.ControlsSystem);
            this.Controls.Add(this.MachineContainer);
            this.Controls.Add(this.labelShowMachine);
            this.Controls.Add(this.btnAddNewMachine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.publicity);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MachineContainer.ResumeLayout(false);
            this.SpinnerLoadingContainer.ResumeLayout(false);
            this.SpinnerLoadingContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicity)).EndInit();
            this.ControlsSystem.ResumeLayout(false);
            this.ControlsSystem.PerformLayout();
            this.TimePanel.ResumeLayout(false);
            this.TimePanel.PerformLayout();
            this.panelLoadClothes.ResumeLayout(false);
            this.panelLoadClothes.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SpinnerLoading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewMachine;
        private System.Windows.Forms.Label labelShowMachine;
        private System.Windows.Forms.Panel MachineContainer;
        private System.Windows.Forms.PictureBox publicity;
        private System.Windows.Forms.Panel SpinnerLoadingContainer;
        private System.Windows.Forms.Panel ControlsSystem;
        private System.Windows.Forms.Label SerialNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button TurnON;
        private System.Windows.Forms.Button TurnOFF;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRealTime;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button loadDetergent;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnDry;
        private System.Windows.Forms.Button btnSpecifyTime;
        private System.Windows.Forms.Button btnLoadClothe;
        private System.Windows.Forms.Button btnLoadWater;
        private System.Windows.Forms.Panel panelLoadClothes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblDetergent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label WashingTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TypeClothing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label stateInWhichItIs;
        private System.Windows.Forms.Panel DecoratorPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFilling;
        private System.Windows.Forms.Panel TimePanel;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.Button BtnLoadTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtnCancelTime;
        private System.Windows.Forms.Button btnStopFilling;
        private System.Windows.Forms.Panel panelTypeOfClothing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSeconds;
    }
}

