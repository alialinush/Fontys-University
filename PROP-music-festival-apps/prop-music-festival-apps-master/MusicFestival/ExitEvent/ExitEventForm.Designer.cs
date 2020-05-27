namespace ExitEvent
{
    partial class ExitEventForm
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
            this.lbRfidStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpenConnection = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExitWithoutReturning = new System.Windows.Forms.Button();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExitAndReturnMoney = new System.Windows.Forms.Button();
            this.btnCheckReturning = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHeading.Location = new System.Drawing.Point(20, 23);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(249, 55);
            this.lbHeading.TabIndex = 0;
            this.lbHeading.Text = "Exit Event";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRfidStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnOpenConnection);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(433, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 280);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RFID Reader";
            // 
            // lbRfidStatus
            // 
            this.lbRfidStatus.AutoSize = true;
            this.lbRfidStatus.Location = new System.Drawing.Point(184, 118);
            this.lbRfidStatus.Name = "lbRfidStatus";
            this.lbRfidStatus.Size = new System.Drawing.Size(33, 20);
            this.lbRfidStatus.TabIndex = 7;
            this.lbRfidStatus.Text = "xxx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status:";
            // 
            // btnOpenConnection
            // 
            this.btnOpenConnection.Location = new System.Drawing.Point(48, 201);
            this.btnOpenConnection.Name = "btnOpenConnection";
            this.btnOpenConnection.Size = new System.Drawing.Size(265, 42);
            this.btnOpenConnection.TabIndex = 0;
            this.btnOpenConnection.Text = "Open RFID connection";
            this.btnOpenConnection.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExitWithoutReturning);
            this.groupBox2.Controls.Add(this.lbBalance);
            this.groupBox2.Controls.Add(this.lbName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnExitAndReturnMoney);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(30, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 356);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Guest Information";
            // 
            // btnExitWithoutReturning
            // 
            this.btnExitWithoutReturning.Location = new System.Drawing.Point(212, 276);
            this.btnExitWithoutReturning.Name = "btnExitWithoutReturning";
            this.btnExitWithoutReturning.Size = new System.Drawing.Size(142, 74);
            this.btnExitWithoutReturning.TabIndex = 8;
            this.btnExitWithoutReturning.Text = "Exit without Returning money";
            this.btnExitWithoutReturning.UseVisualStyleBackColor = true;
            this.btnExitWithoutReturning.Click += new System.EventHandler(this.btnExitWithoutReturning_Click);
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(217, 145);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(33, 20);
            this.lbBalance.TabIndex = 7;
            this.lbBalance.Text = "xxx";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(217, 85);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(33, 20);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "xxx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // btnExitAndReturnMoney
            // 
            this.btnExitAndReturnMoney.Location = new System.Drawing.Point(6, 276);
            this.btnExitAndReturnMoney.Name = "btnExitAndReturnMoney";
            this.btnExitAndReturnMoney.Size = new System.Drawing.Size(128, 74);
            this.btnExitAndReturnMoney.TabIndex = 1;
            this.btnExitAndReturnMoney.Text = "Exit and Return Money";
            this.btnExitAndReturnMoney.UseVisualStyleBackColor = true;
            this.btnExitAndReturnMoney.Click += new System.EventHandler(this.btnExitAndReturnMoney_Click);
            // 
            // btnCheckReturning
            // 
            this.btnCheckReturning.Enabled = false;
            this.btnCheckReturning.Location = new System.Drawing.Point(922, 402);
            this.btnCheckReturning.Name = "btnCheckReturning";
            this.btnCheckReturning.Size = new System.Drawing.Size(212, 52);
            this.btnCheckReturning.TabIndex = 9;
            this.btnCheckReturning.Text = "Return";
            this.btnCheckReturning.UseVisualStyleBackColor = true;
            this.btnCheckReturning.Click += new System.EventHandler(this.btnCheckReturning_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(841, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 356);
            this.listBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Show items to return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCheckReturning);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbHeading);
            this.Name = "ExitEventForm";
            this.Text = "Exit Event";
            this.Load += new System.EventHandler(this.ExitEventForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenConnection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExitAndReturnMoney;
        private System.Windows.Forms.Label lbRfidStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnExitWithoutReturning;
        private System.Windows.Forms.Button btnCheckReturning;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

