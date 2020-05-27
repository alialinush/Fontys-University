namespace CreateEvent
{
    partial class CreateEventForm
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
            this.lbHeading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTicketPrice = new System.Windows.Forms.TextBox();
            this.tbNrTicketsAvailable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCampingSpotPrice = new System.Windows.Forms.TextBox();
            this.tbNrSpotsAvailable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbLineUp = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbEventId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.datetimeEND = new System.Windows.Forms.DateTimePicker();
            this.datetimeSTART = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btCreateEvent = new System.Windows.Forms.Button();
            this.lbCountingEvents = new System.Windows.Forms.Label();
            this.rbImportAliments = new System.Windows.Forms.RadioButton();
            this.rbImportForLoaningShop = new System.Windows.Forms.RadioButton();
            this.lbCountEvents = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeading.Location = new System.Drawing.Point(230, 9);
            this.lbHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(213, 37);
            this.lbHeading.TabIndex = 1;
            this.lbHeading.Text = "Create Event";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTicketPrice);
            this.groupBox1.Controls.Add(this.tbNrTicketsAvailable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(34, 370);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(297, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets";
            // 
            // tbTicketPrice
            // 
            this.tbTicketPrice.Location = new System.Drawing.Point(204, 75);
            this.tbTicketPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbTicketPrice.Name = "tbTicketPrice";
            this.tbTicketPrice.Size = new System.Drawing.Size(76, 23);
            this.tbTicketPrice.TabIndex = 5;
            // 
            // tbNrTicketsAvailable
            // 
            this.tbNrTicketsAvailable.Location = new System.Drawing.Point(204, 41);
            this.tbNrTicketsAvailable.Margin = new System.Windows.Forms.Padding(2);
            this.tbNrTicketsAvailable.Name = "tbNrTicketsAvailable";
            this.tbNrTicketsAvailable.Size = new System.Drawing.Size(76, 23);
            this.tbNrTicketsAvailable.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ticket price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of tickets available:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCampingSpotPrice);
            this.groupBox2.Controls.Add(this.tbNrSpotsAvailable);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(34, 482);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(297, 108);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camping spots";
            // 
            // tbCampingSpotPrice
            // 
            this.tbCampingSpotPrice.Location = new System.Drawing.Point(204, 75);
            this.tbCampingSpotPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbCampingSpotPrice.Name = "tbCampingSpotPrice";
            this.tbCampingSpotPrice.Size = new System.Drawing.Size(76, 23);
            this.tbCampingSpotPrice.TabIndex = 5;
            // 
            // tbNrSpotsAvailable
            // 
            this.tbNrSpotsAvailable.Location = new System.Drawing.Point(204, 39);
            this.tbNrSpotsAvailable.Margin = new System.Windows.Forms.Padding(2);
            this.tbNrSpotsAvailable.Name = "tbNrSpotsAvailable";
            this.tbNrSpotsAvailable.Size = new System.Drawing.Size(76, 23);
            this.tbNrSpotsAvailable.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Camping spot price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of spots available:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemove);
            this.groupBox3.Controls.Add(this.lbLineUp);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.tbArtist);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(354, 80);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(350, 311);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Line Up";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemove.Location = new System.Drawing.Point(17, 268);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 32);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbLineUp
            // 
            this.lbLineUp.FormattingEnabled = true;
            this.lbLineUp.ItemHeight = 17;
            this.lbLineUp.Location = new System.Drawing.Point(17, 63);
            this.lbLineUp.Margin = new System.Windows.Forms.Padding(2);
            this.lbLineUp.Name = "lbLineUp";
            this.lbLineUp.Size = new System.Drawing.Size(308, 191);
            this.lbLineUp.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(263, 24);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 32);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(63, 32);
            this.tbArtist.Margin = new System.Windows.Forms.Padding(2);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(182, 23);
            this.tbArtist.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Artist:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbEventId);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbUserId);
            this.groupBox4.Controls.Add(this.datetimeEND);
            this.groupBox4.Controls.Add(this.datetimeSTART);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tbLocation);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tbDescription);
            this.groupBox4.Controls.Add(this.tbName);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(34, 65);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(297, 301);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Information";
            // 
            // tbEventId
            // 
            this.tbEventId.Location = new System.Drawing.Point(104, 32);
            this.tbEventId.Name = "tbEventId";
            this.tbEventId.Size = new System.Drawing.Size(63, 23);
            this.tbEventId.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "EventId:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "UserId:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 264);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "End Date:";
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(104, 61);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.Size = new System.Drawing.Size(61, 23);
            this.tbUserId.TabIndex = 14;
            this.tbUserId.TextChanged += new System.EventHandler(this.tbuserId_TextChanged);
            // 
            // datetimeEND
            // 
            this.datetimeEND.Cursor = System.Windows.Forms.Cursors.No;
            this.datetimeEND.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.datetimeEND.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeEND.Location = new System.Drawing.Point(115, 259);
            this.datetimeEND.Margin = new System.Windows.Forms.Padding(2);
            this.datetimeEND.Name = "datetimeEND";
            this.datetimeEND.Size = new System.Drawing.Size(164, 23);
            this.datetimeEND.TabIndex = 10;
            // 
            // datetimeSTART
            // 
            this.datetimeSTART.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.datetimeSTART.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeSTART.Location = new System.Drawing.Point(115, 223);
            this.datetimeSTART.Margin = new System.Windows.Forms.Padding(2);
            this.datetimeSTART.Name = "datetimeSTART";
            this.datetimeSTART.Size = new System.Drawing.Size(164, 23);
            this.datetimeSTART.TabIndex = 9;
            this.datetimeSTART.Value = new System.DateTime(2019, 5, 18, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 228);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Start Date:";
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(115, 186);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(151, 23);
            this.tbLocation.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 189);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Location:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(115, 150);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(151, 23);
            this.tbDescription.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(115, 114);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(101, 23);
            this.tbName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Name:";
            // 
            // btCreateEvent
            // 
            this.btCreateEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateEvent.Location = new System.Drawing.Point(443, 411);
            this.btCreateEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btCreateEvent.Name = "btCreateEvent";
            this.btCreateEvent.Size = new System.Drawing.Size(199, 59);
            this.btCreateEvent.TabIndex = 13;
            this.btCreateEvent.Text = "Create Event";
            this.btCreateEvent.UseVisualStyleBackColor = true;
            this.btCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // lbCountingEvents
            // 
            this.lbCountingEvents.AutoSize = true;
            this.lbCountingEvents.Location = new System.Drawing.Point(503, 482);
            this.lbCountingEvents.Name = "lbCountingEvents";
            this.lbCountingEvents.Size = new System.Drawing.Size(0, 13);
            this.lbCountingEvents.TabIndex = 15;
            // 
            // rbImportAliments
            // 
            this.rbImportAliments.AutoSize = true;
            this.rbImportAliments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbImportAliments.Location = new System.Drawing.Point(443, 509);
            this.rbImportAliments.Name = "rbImportAliments";
            this.rbImportAliments.Size = new System.Drawing.Size(220, 22);
            this.rbImportAliments.TabIndex = 16;
            this.rbImportAliments.TabStop = true;
            this.rbImportAliments.Text = "Import aliments for food shop";
            this.rbImportAliments.UseVisualStyleBackColor = true;
            this.rbImportAliments.CheckedChanged += new System.EventHandler(this.rbImportAliments_CheckedChanged);
            // 
            // rbImportForLoaningShop
            // 
            this.rbImportForLoaningShop.AutoSize = true;
            this.rbImportForLoaningShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbImportForLoaningShop.Location = new System.Drawing.Point(439, 537);
            this.rbImportForLoaningShop.Name = "rbImportForLoaningShop";
            this.rbImportForLoaningShop.Size = new System.Drawing.Size(240, 22);
            this.rbImportForLoaningShop.TabIndex = 17;
            this.rbImportForLoaningShop.TabStop = true;
            this.rbImportForLoaningShop.Text = "Import products for loaning shop";
            this.rbImportForLoaningShop.UseVisualStyleBackColor = true;
            this.rbImportForLoaningShop.CheckedChanged += new System.EventHandler(this.rbImportForLoaningShop_CheckedChanged);
            // 
            // lbCountEvents
            // 
            this.lbCountEvents.AutoSize = true;
            this.lbCountEvents.Location = new System.Drawing.Point(436, 577);
            this.lbCountEvents.Name = "lbCountEvents";
            this.lbCountEvents.Size = new System.Drawing.Size(0, 13);
            this.lbCountEvents.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(336, 577);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Events created:";
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 602);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbCountEvents);
            this.Controls.Add(this.rbImportForLoaningShop);
            this.Controls.Add(this.rbImportAliments);
            this.Controls.Add(this.lbCountingEvents);
            this.Controls.Add(this.btCreateEvent);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbHeading);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateEventForm";
            this.Text = "Create Event";
            this.Load += new System.EventHandler(this.CreateEventForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTicketPrice;
        private System.Windows.Forms.TextBox tbNrTicketsAvailable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCampingSpotPrice;
        private System.Windows.Forms.TextBox tbNrSpotsAvailable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbLineUp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datetimeEND;
        private System.Windows.Forms.DateTimePicker datetimeSTART;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btCreateEvent;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label lbCountingEvents;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbEventId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbImportAliments;
        private System.Windows.Forms.RadioButton rbImportForLoaningShop;
        private System.Windows.Forms.Label lbCountEvents;
        private System.Windows.Forms.Label label13;
    }
}

