namespace TrafficDemo
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Header = new System.Windows.Forms.Label();
            this.gridsizelabel = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.reportbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVehicelsAmount = new System.Windows.Forms.TextBox();
            this.environmentslabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleslabel = new System.Windows.Forms.Label();
            this.pedestrianslabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pdstrupper = new System.Windows.Forms.TextBox();
            this.pdstrlower = new System.Windows.Forms.TextBox();
            this.trackBarPedestrians = new System.Windows.Forms.TrackBar();
            this.surpriseelementslabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sprselcheckbox = new System.Windows.Forms.CheckBox();
            this.resetvaluesbtn = new System.Windows.Forms.Button();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TrackBarSpeed = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.envonebtn = new System.Windows.Forms.Button();
            this.envtwobtn = new System.Windows.Forms.Button();
            this.envthreebtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblEmergency = new System.Windows.Forms.Label();
            this.btnChooseDestination = new System.Windows.Forms.Button();
            this.btnVehicleStart = new System.Windows.Forms.Button();
            this.dragAndDropPanel = new System.Windows.Forms.Panel();
            this.btnFlip = new System.Windows.Forms.Button();
            this.TwoWay = new System.Windows.Forms.PictureBox();
            this.roundabout = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.roadType1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.roadType2 = new System.Windows.Forms.PictureBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeCrossingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.listbox1 = new System.Windows.Forms.ListBox();
            this.timerActualTime = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnSmallGridSelected = new System.Windows.Forms.Button();
            this.btnMiddleGridSelected = new System.Windows.Forms.Button();
            this.btnLargeGridSelected = new System.Windows.Forms.Button();
            this.saveasbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.openbtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPedestrians)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSpeed)).BeginInit();
            this.dragAndDropPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TwoWay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundabout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadType2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 75;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header.Location = new System.Drawing.Point(9, 166);
            this.Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(197, 29);
            this.Header.TabIndex = 3;
            this.Header.Text = "Hyena Crossing";
            // 
            // gridsizelabel
            // 
            this.gridsizelabel.AutoSize = true;
            this.gridsizelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridsizelabel.Location = new System.Drawing.Point(62, 302);
            this.gridsizelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gridsizelabel.Name = "gridsizelabel";
            this.gridsizelabel.Size = new System.Drawing.Size(74, 20);
            this.gridsizelabel.TabIndex = 4;
            this.gridsizelabel.Text = "Grid Size";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(14, 542);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(170, 55);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // reportbtn
            // 
            this.reportbtn.BackColor = System.Drawing.Color.Transparent;
            this.reportbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportbtn.Location = new System.Drawing.Point(14, 612);
            this.reportbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.Size = new System.Drawing.Size(170, 55);
            this.reportbtn.TabIndex = 10;
            this.reportbtn.Text = "Generate report";
            this.reportbtn.UseVisualStyleBackColor = false;
            this.reportbtn.Click += new System.EventHandler(this.reportbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "__________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "__________________";
            // 
            // tbVehicelsAmount
            // 
            this.tbVehicelsAmount.Location = new System.Drawing.Point(152, 219);
            this.tbVehicelsAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbVehicelsAmount.Name = "tbVehicelsAmount";
            this.tbVehicelsAmount.Size = new System.Drawing.Size(34, 20);
            this.tbVehicelsAmount.TabIndex = 18;
            this.tbVehicelsAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbVehicelsAmount.TextChanged += new System.EventHandler(this.tbVehicelsAmount_TextChanged);
            // 
            // environmentslabel
            // 
            this.environmentslabel.AutoSize = true;
            this.environmentslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.environmentslabel.Location = new System.Drawing.Point(122, 23);
            this.environmentslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.environmentslabel.Name = "environmentslabel";
            this.environmentslabel.Size = new System.Drawing.Size(106, 20);
            this.environmentslabel.TabIndex = 22;
            this.environmentslabel.Text = "Environments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(92, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "__________________";
            // 
            // vehicleslabel
            // 
            this.vehicleslabel.AutoSize = true;
            this.vehicleslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vehicleslabel.Location = new System.Drawing.Point(104, 168);
            this.vehicleslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vehicleslabel.Name = "vehicleslabel";
            this.vehicleslabel.Size = new System.Drawing.Size(130, 20);
            this.vehicleslabel.TabIndex = 24;
            this.vehicleslabel.Text = "Vehicles per lane";
            // 
            // pedestrianslabel
            // 
            this.pedestrianslabel.AutoSize = true;
            this.pedestrianslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pedestrianslabel.Location = new System.Drawing.Point(135, 376);
            this.pedestrianslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pedestrianslabel.Name = "pedestrianslabel";
            this.pedestrianslabel.Size = new System.Drawing.Size(93, 20);
            this.pedestrianslabel.TabIndex = 29;
            this.pedestrianslabel.Text = "Pedestrians";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(92, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "__________________";
            // 
            // pdstrupper
            // 
            this.pdstrupper.Location = new System.Drawing.Point(262, 433);
            this.pdstrupper.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pdstrupper.Name = "pdstrupper";
            this.pdstrupper.Size = new System.Drawing.Size(34, 20);
            this.pdstrupper.TabIndex = 27;
            // 
            // pdstrlower
            // 
            this.pdstrlower.Location = new System.Drawing.Point(55, 433);
            this.pdstrlower.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pdstrlower.Name = "pdstrlower";
            this.pdstrlower.Size = new System.Drawing.Size(34, 20);
            this.pdstrlower.TabIndex = 26;
            // 
            // trackBarPedestrians
            // 
            this.trackBarPedestrians.Location = new System.Drawing.Point(108, 433);
            this.trackBarPedestrians.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trackBarPedestrians.Maximum = 5;
            this.trackBarPedestrians.Name = "trackBarPedestrians";
            this.trackBarPedestrians.Size = new System.Drawing.Size(132, 45);
            this.trackBarPedestrians.TabIndex = 25;
            this.trackBarPedestrians.Scroll += new System.EventHandler(this.trackBarPedestrians_Scroll);
            // 
            // surpriseelementslabel
            // 
            this.surpriseelementslabel.AutoSize = true;
            this.surpriseelementslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surpriseelementslabel.Location = new System.Drawing.Point(92, 704);
            this.surpriseelementslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surpriseelementslabel.Name = "surpriseelementslabel";
            this.surpriseelementslabel.Size = new System.Drawing.Size(139, 20);
            this.surpriseelementslabel.TabIndex = 30;
            this.surpriseelementslabel.Text = "Surprise Elements";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(92, 560);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "__________________";
            // 
            // sprselcheckbox
            // 
            this.sprselcheckbox.AutoSize = true;
            this.sprselcheckbox.Location = new System.Drawing.Point(266, 704);
            this.sprselcheckbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.sprselcheckbox.Name = "sprselcheckbox";
            this.sprselcheckbox.Size = new System.Drawing.Size(15, 14);
            this.sprselcheckbox.TabIndex = 32;
            this.sprselcheckbox.UseVisualStyleBackColor = true;
            this.sprselcheckbox.CheckedChanged += new System.EventHandler(this.sprselcheckbox_CheckedChanged);
            // 
            // resetvaluesbtn
            // 
            this.resetvaluesbtn.BackColor = System.Drawing.Color.Transparent;
            this.resetvaluesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetvaluesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetvaluesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetvaluesbtn.Location = new System.Drawing.Point(96, 742);
            this.resetvaluesbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.resetvaluesbtn.Name = "resetvaluesbtn";
            this.resetvaluesbtn.Size = new System.Drawing.Size(170, 55);
            this.resetvaluesbtn.TabIndex = 33;
            this.resetvaluesbtn.Text = "Reset Default Values";
            this.resetvaluesbtn.UseVisualStyleBackColor = false;
            this.resetvaluesbtn.Click += new System.EventHandler(this.resetvaluesbtn_Click);
            // 
            // gridPanel
            // 
            this.gridPanel.AllowDrop = true;
            this.gridPanel.AutoScrollMargin = new System.Drawing.Size(0, 200);
            this.gridPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridPanel.Location = new System.Drawing.Point(249, 160);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(600, 400);
            this.gridPanel.TabIndex = 40;
            this.gridPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.gridPanel_DragDrop);
            this.gridPanel.DragOver += new System.Windows.Forms.DragEventHandler(this.gridPanel_DragOver);
            this.gridPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gridPanel_Paint);
            // 
            // settingsPanel
            // 
            this.settingsPanel.AllowDrop = true;
            this.settingsPanel.AutoScrollMargin = new System.Drawing.Size(0, 200);
            this.settingsPanel.Controls.Add(this.label7);
            this.settingsPanel.Controls.Add(this.textBox2);
            this.settingsPanel.Controls.Add(this.TrackBarSpeed);
            this.settingsPanel.Controls.Add(this.textBox1);
            this.settingsPanel.Controls.Add(this.label4);
            this.settingsPanel.Controls.Add(this.environmentslabel);
            this.settingsPanel.Controls.Add(this.envonebtn);
            this.settingsPanel.Controls.Add(this.trackBarPedestrians);
            this.settingsPanel.Controls.Add(this.envtwobtn);
            this.settingsPanel.Controls.Add(this.pdstrupper);
            this.settingsPanel.Controls.Add(this.envthreebtn);
            this.settingsPanel.Controls.Add(this.pdstrlower);
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Controls.Add(this.label8);
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.Controls.Add(this.vehicleslabel);
            this.settingsPanel.Controls.Add(this.pedestrianslabel);
            this.settingsPanel.Controls.Add(this.checkBox1);
            this.settingsPanel.Controls.Add(this.sprselcheckbox);
            this.settingsPanel.Controls.Add(this.lblEmergency);
            this.settingsPanel.Controls.Add(this.surpriseelementslabel);
            this.settingsPanel.Controls.Add(this.tbVehicelsAmount);
            this.settingsPanel.Controls.Add(this.label6);
            this.settingsPanel.Controls.Add(this.btnChooseDestination);
            this.settingsPanel.Controls.Add(this.btnVehicleStart);
            this.settingsPanel.Controls.Add(this.resetvaluesbtn);
            this.settingsPanel.Location = new System.Drawing.Point(884, 6);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(347, 813);
            this.settingsPanel.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(106, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Simulation Time";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 310);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(34, 20);
            this.textBox2.TabIndex = 37;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TrackBarSpeed
            // 
            this.TrackBarSpeed.Location = new System.Drawing.Point(118, 523);
            this.TrackBarSpeed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TrackBarSpeed.Maximum = 15;
            this.TrackBarSpeed.Name = "TrackBarSpeed";
            this.TrackBarSpeed.Size = new System.Drawing.Size(132, 45);
            this.TrackBarSpeed.TabIndex = 34;
            this.TrackBarSpeed.Scroll += new System.EventHandler(this.TrackBarSpeed_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 523);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(34, 20);
            this.textBox1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(122, 482);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Simulation speed";
            // 
            // envonebtn
            // 
            this.envonebtn.BackColor = System.Drawing.Color.Transparent;
            this.envonebtn.BackgroundImage = global::TrafficDemo.Properties.Resources.sun;
            this.envonebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.envonebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.envonebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.envonebtn.Location = new System.Drawing.Point(65, 68);
            this.envonebtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.envonebtn.Name = "envonebtn";
            this.envonebtn.Size = new System.Drawing.Size(46, 42);
            this.envonebtn.TabIndex = 15;
            this.envonebtn.UseVisualStyleBackColor = false;
            this.envonebtn.Click += new System.EventHandler(this.envonebtn_Click);
            this.envonebtn.MouseHover += new System.EventHandler(this.envonebtn_MouseHover);
            // 
            // envtwobtn
            // 
            this.envtwobtn.BackColor = System.Drawing.Color.Transparent;
            this.envtwobtn.BackgroundImage = global::TrafficDemo.Properties.Resources.moon;
            this.envtwobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.envtwobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.envtwobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.envtwobtn.Location = new System.Drawing.Point(152, 68);
            this.envtwobtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.envtwobtn.Name = "envtwobtn";
            this.envtwobtn.Size = new System.Drawing.Size(46, 42);
            this.envtwobtn.TabIndex = 14;
            this.envtwobtn.UseVisualStyleBackColor = false;
            this.envtwobtn.Click += new System.EventHandler(this.envtwobtn_Click);
            this.envtwobtn.MouseHover += new System.EventHandler(this.envtwobtn_MouseHover);
            // 
            // envthreebtn
            // 
            this.envthreebtn.BackColor = System.Drawing.Color.Transparent;
            this.envthreebtn.BackgroundImage = global::TrafficDemo.Properties.Resources.traffic;
            this.envthreebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.envthreebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.envthreebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.envthreebtn.Location = new System.Drawing.Point(250, 68);
            this.envthreebtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.envthreebtn.Name = "envthreebtn";
            this.envthreebtn.Size = new System.Drawing.Size(46, 42);
            this.envthreebtn.TabIndex = 13;
            this.envthreebtn.UseVisualStyleBackColor = false;
            this.envthreebtn.Click += new System.EventHandler(this.envthreebtn_Click);
            this.envthreebtn.MouseHover += new System.EventHandler(this.envthreebtn_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(92, 667);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "__________________";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(266, 601);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.sprselcheckbox_CheckedChanged);
            // 
            // lblEmergency
            // 
            this.lblEmergency.AutoSize = true;
            this.lblEmergency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmergency.Location = new System.Drawing.Point(89, 596);
            this.lblEmergency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmergency.Name = "lblEmergency";
            this.lblEmergency.Size = new System.Drawing.Size(153, 20);
            this.lblEmergency.TabIndex = 30;
            this.lblEmergency.Text = "Emergency Vehicles";
            // 
            // btnChooseDestination
            // 
            this.btnChooseDestination.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseDestination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseDestination.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChooseDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChooseDestination.Location = new System.Drawing.Point(184, 635);
            this.btnChooseDestination.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChooseDestination.Name = "btnChooseDestination";
            this.btnChooseDestination.Size = new System.Drawing.Size(94, 29);
            this.btnChooseDestination.TabIndex = 33;
            this.btnChooseDestination.Text = "Destination";
            this.btnChooseDestination.UseVisualStyleBackColor = false;
            this.btnChooseDestination.Click += new System.EventHandler(this.resetvaluesbtn_Click);
            // 
            // btnVehicleStart
            // 
            this.btnVehicleStart.BackColor = System.Drawing.Color.Transparent;
            this.btnVehicleStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVehicleStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVehicleStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVehicleStart.Location = new System.Drawing.Point(77, 635);
            this.btnVehicleStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVehicleStart.Name = "btnVehicleStart";
            this.btnVehicleStart.Size = new System.Drawing.Size(94, 29);
            this.btnVehicleStart.TabIndex = 33;
            this.btnVehicleStart.Text = "Start";
            this.btnVehicleStart.UseVisualStyleBackColor = false;
            this.btnVehicleStart.Click += new System.EventHandler(this.resetvaluesbtn_Click);
            // 
            // dragAndDropPanel
            // 
            this.dragAndDropPanel.AllowDrop = true;
            this.dragAndDropPanel.AutoScrollMargin = new System.Drawing.Size(0, 200);
            this.dragAndDropPanel.Controls.Add(this.btnFlip);
            this.dragAndDropPanel.Controls.Add(this.TwoWay);
            this.dragAndDropPanel.Controls.Add(this.roundabout);
            this.dragAndDropPanel.Controls.Add(this.btnStop);
            this.dragAndDropPanel.Controls.Add(this.roadType1);
            this.dragAndDropPanel.Controls.Add(this.btnStart);
            this.dragAndDropPanel.Controls.Add(this.roadType2);
            this.dragAndDropPanel.Controls.Add(this.btnPause);
            this.dragAndDropPanel.Location = new System.Drawing.Point(249, 6);
            this.dragAndDropPanel.Name = "dragAndDropPanel";
            this.dragAndDropPanel.Size = new System.Drawing.Size(600, 152);
            this.dragAndDropPanel.TabIndex = 41;
            // 
            // btnFlip
            // 
            this.btnFlip.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnFlip.BackColor = System.Drawing.Color.Transparent;
            this.btnFlip.BackgroundImage = global::TrafficDemo.Properties.Resources.flip;
            this.btnFlip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFlip.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnFlip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFlip.Location = new System.Drawing.Point(547, 34);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(39, 29);
            this.btnFlip.TabIndex = 42;
            this.btnFlip.UseVisualStyleBackColor = false;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // TwoWay
            // 
            this.TwoWay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TwoWay.Image = global::TrafficDemo.Properties.Resources.twoWay_h;
            this.TwoWay.Location = new System.Drawing.Point(462, 52);
            this.TwoWay.Name = "TwoWay";
            this.TwoWay.Size = new System.Drawing.Size(111, 96);
            this.TwoWay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TwoWay.TabIndex = 41;
            this.TwoWay.TabStop = false;
            this.TwoWay.Tag = "two-way-h";
            this.TwoWay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TwoWay_MouseDown);
            // 
            // roundabout
            // 
            this.roundabout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundabout.Image = global::TrafficDemo.Properties.Resources.roundabout;
            this.roundabout.Location = new System.Drawing.Point(318, 52);
            this.roundabout.Name = "roundabout";
            this.roundabout.Size = new System.Drawing.Size(111, 96);
            this.roundabout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundabout.TabIndex = 40;
            this.roundabout.TabStop = false;
            this.roundabout.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roundabout_MouseDown);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = global::TrafficDemo.Properties.Resources.stop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(358, 0);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(46, 42);
            this.btnStop.TabIndex = 36;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.MouseHover += new System.EventHandler(this.btnStop_MouseHover);
            // 
            // roadType1
            // 
            this.roadType1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roadType1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roadType1.ErrorImage = null;
            this.roadType1.Image = global::TrafficDemo.Properties.Resources.roadType1;
            this.roadType1.InitialImage = null;
            this.roadType1.Location = new System.Drawing.Point(10, 52);
            this.roadType1.Name = "roadType1";
            this.roadType1.Size = new System.Drawing.Size(111, 96);
            this.roadType1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadType1.TabIndex = 38;
            this.roadType1.TabStop = false;
            this.roadType1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roadType1_MouseDown);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::TrafficDemo.Properties.Resources.play;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(202, 0);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(46, 42);
            this.btnStart.TabIndex = 34;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseHover += new System.EventHandler(this.btnStart_MouseHover);
            // 
            // roadType2
            // 
            this.roadType2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roadType2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roadType2.Image = global::TrafficDemo.Properties.Resources.roadType2;
            this.roadType2.Location = new System.Drawing.Point(166, 52);
            this.roadType2.Name = "roadType2";
            this.roadType2.Size = new System.Drawing.Size(111, 96);
            this.roadType2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadType2.TabIndex = 39;
            this.roadType2.TabStop = false;
            this.roadType2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roadType2_MouseDown);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = global::TrafficDemo.Properties.Resources.pause;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPause.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPause.Location = new System.Drawing.Point(279, 0);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(46, 42);
            this.btnPause.TabIndex = 35;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            this.btnPause.MouseHover += new System.EventHandler(this.btnPause_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeCrossingToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // removeCrossingToolStripMenuItem
            // 
            this.removeCrossingToolStripMenuItem.Name = "removeCrossingToolStripMenuItem";
            this.removeCrossingToolStripMenuItem.ShortcutKeyDisplayString = "R";
            this.removeCrossingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeCrossingToolStripMenuItem.Text = "&Remove Crossing";
            this.removeCrossingToolStripMenuItem.Click += new System.EventHandler(this.removeCrossingToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // listbox1
            // 
            this.listbox1.BackColor = System.Drawing.Color.White;
            this.listbox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox1.ForeColor = System.Drawing.Color.Black;
            this.listbox1.FormattingEnabled = true;
            this.listbox1.ItemHeight = 16;
            this.listbox1.Location = new System.Drawing.Point(249, 585);
            this.listbox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(606, 96);
            this.listbox1.TabIndex = 45;
            this.listbox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listbox1_DrawItem);
            this.listbox1.SelectedIndexChanged += new System.EventHandler(this.listbox1_SelectedIndexChanged);
            // 
            // timerActualTime
            // 
            this.timerActualTime.Interval = 1000;
            this.timerActualTime.Tick += new System.EventHandler(this.timerActualTime_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnSmallGridSelected
            // 
            this.btnSmallGridSelected.BackColor = System.Drawing.Color.Transparent;
            this.btnSmallGridSelected.BackgroundImage = global::TrafficDemo.Properties.Resources.stop;
            this.btnSmallGridSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSmallGridSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmallGridSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSmallGridSelected.Location = new System.Drawing.Point(14, 334);
            this.btnSmallGridSelected.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSmallGridSelected.Name = "btnSmallGridSelected";
            this.btnSmallGridSelected.Size = new System.Drawing.Size(46, 42);
            this.btnSmallGridSelected.TabIndex = 7;
            this.btnSmallGridSelected.UseVisualStyleBackColor = false;
            this.btnSmallGridSelected.Click += new System.EventHandler(this.btnSmallGridSelected_Click);
            this.btnSmallGridSelected.MouseHover += new System.EventHandler(this.btnSmallGridSelected_MouseHover);
            // 
            // btnMiddleGridSelected
            // 
            this.btnMiddleGridSelected.BackColor = System.Drawing.Color.Transparent;
            this.btnMiddleGridSelected.BackgroundImage = global::TrafficDemo.Properties.Resources.four;
            this.btnMiddleGridSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMiddleGridSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiddleGridSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMiddleGridSelected.Location = new System.Drawing.Point(76, 334);
            this.btnMiddleGridSelected.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMiddleGridSelected.Name = "btnMiddleGridSelected";
            this.btnMiddleGridSelected.Size = new System.Drawing.Size(46, 42);
            this.btnMiddleGridSelected.TabIndex = 6;
            this.btnMiddleGridSelected.UseVisualStyleBackColor = false;
            this.btnMiddleGridSelected.Click += new System.EventHandler(this.btnMiddleGridSelected_Click);
            this.btnMiddleGridSelected.MouseHover += new System.EventHandler(this.btnMiddleGridSelected_MouseHover);
            // 
            // btnLargeGridSelected
            // 
            this.btnLargeGridSelected.BackColor = System.Drawing.Color.Transparent;
            this.btnLargeGridSelected.BackgroundImage = global::TrafficDemo.Properties.Resources.nine;
            this.btnLargeGridSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLargeGridSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLargeGridSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLargeGridSelected.Location = new System.Drawing.Point(137, 334);
            this.btnLargeGridSelected.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLargeGridSelected.Name = "btnLargeGridSelected";
            this.btnLargeGridSelected.Size = new System.Drawing.Size(46, 42);
            this.btnLargeGridSelected.TabIndex = 5;
            this.btnLargeGridSelected.UseVisualStyleBackColor = false;
            this.btnLargeGridSelected.Click += new System.EventHandler(this.btnLargeGridSelected_Click);
            this.btnLargeGridSelected.MouseHover += new System.EventHandler(this.btnLargeGridSelected_MouseHover);
            // 
            // saveasbtn
            // 
            this.saveasbtn.BackColor = System.Drawing.Color.Transparent;
            this.saveasbtn.BackgroundImage = global::TrafficDemo.Properties.Resources.saveas;
            this.saveasbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveasbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveasbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveasbtn.Location = new System.Drawing.Point(137, 74);
            this.saveasbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveasbtn.Name = "saveasbtn";
            this.saveasbtn.Size = new System.Drawing.Size(46, 42);
            this.saveasbtn.TabIndex = 2;
            this.saveasbtn.UseVisualStyleBackColor = false;
            this.saveasbtn.Click += new System.EventHandler(this.saveasbtn_Click);
            this.saveasbtn.MouseHover += new System.EventHandler(this.saveasbtn_MouseHover);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Transparent;
            this.savebtn.BackgroundImage = global::TrafficDemo.Properties.Resources.save;
            this.savebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savebtn.Location = new System.Drawing.Point(83, 74);
            this.savebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(46, 42);
            this.savebtn.TabIndex = 1;
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            this.savebtn.MouseHover += new System.EventHandler(this.savebtn_MouseHover);
            // 
            // openbtn
            // 
            this.openbtn.BackColor = System.Drawing.Color.Transparent;
            this.openbtn.BackgroundImage = global::TrafficDemo.Properties.Resources.open;
            this.openbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.openbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openbtn.Location = new System.Drawing.Point(25, 74);
            this.openbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(46, 42);
            this.openbtn.TabIndex = 0;
            this.openbtn.UseVisualStyleBackColor = false;
            this.openbtn.Click += new System.EventHandler(this.openbtn_Click);
            this.openbtn.MouseHover += new System.EventHandler(this.openbtn_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(14, 462);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 37);
            this.button1.TabIndex = 46;
            this.button1.Text = "Current flow of cars";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listbox1);
            this.Controls.Add(this.dragAndDropPanel);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reportbtn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSmallGridSelected);
            this.Controls.Add(this.btnMiddleGridSelected);
            this.Controls.Add(this.btnLargeGridSelected);
            this.Controls.Add(this.gridsizelabel);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.saveasbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.openbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPedestrians)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSpeed)).EndInit();
            this.dragAndDropPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TwoWay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundabout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadType2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button openbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button saveasbtn;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label gridsizelabel;
        private System.Windows.Forms.Button btnSmallGridSelected;
        private System.Windows.Forms.Button btnMiddleGridSelected;
        private System.Windows.Forms.Button btnLargeGridSelected;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button reportbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button envonebtn;
        private System.Windows.Forms.Button envtwobtn;
        private System.Windows.Forms.Button envthreebtn;
        private System.Windows.Forms.TextBox tbVehicelsAmount;
        private System.Windows.Forms.Label environmentslabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vehicleslabel;
        private System.Windows.Forms.Label pedestrianslabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pdstrupper;
        private System.Windows.Forms.TextBox pdstrlower;
        private System.Windows.Forms.TrackBar trackBarPedestrians;
        private System.Windows.Forms.Label surpriseelementslabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox sprselcheckbox;
        private System.Windows.Forms.Button resetvaluesbtn;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Panel dragAndDropPanel;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.PictureBox roadType1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox roadType2;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeCrossingToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ListBox listbox1;
       private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Timer timerActualTime;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox roundabout;
        private System.Windows.Forms.PictureBox TwoWay;
        private System.Windows.Forms.Button btnFlip;
        private System.Windows.Forms.TrackBar TrackBarSpeed;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblEmergency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChooseDestination;
        private System.Windows.Forms.Button btnVehicleStart;
    }
}

