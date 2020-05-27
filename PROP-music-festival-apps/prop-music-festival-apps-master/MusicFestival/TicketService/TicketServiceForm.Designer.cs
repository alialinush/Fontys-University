namespace Ticket_Service
{
    partial class TicketServiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbCreateAccount = new System.Windows.Forms.GroupBox();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBankAccountId = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbVerifyAccount = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tbTicketNo = new System.Windows.Forms.TextBox();
            this.lbTicketNo = new System.Windows.Forms.Label();
            this.rbTicketSale = new System.Windows.Forms.RadioButton();
            this.rbTicketExchange = new System.Windows.Forms.RadioButton();
            this.gbRFID = new System.Windows.Forms.GroupBox();
            this.lbSerialNo = new System.Windows.Forms.Label();
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.lblValidRFIDNo = new System.Windows.Forms.Label();
            this.btnBindToAccount = new System.Windows.Forms.Button();
            this.btnOpenRFID = new System.Windows.Forms.Button();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbCreateAccount.SuspendLayout();
            this.gbVerifyAccount.SuspendLayout();
            this.gbRFID.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticket Service";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.gbCreateAccount);
            this.panel1.Controls.Add(this.gbVerifyAccount);
            this.panel1.Controls.Add(this.rbTicketSale);
            this.panel1.Controls.Add(this.rbTicketExchange);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 318);
            this.panel1.TabIndex = 2;
            // 
            // gbCreateAccount
            // 
            this.gbCreateAccount.Controls.Add(this.tbStatus);
            this.gbCreateAccount.Controls.Add(this.label8);
            this.gbCreateAccount.Controls.Add(this.label7);
            this.gbCreateAccount.Controls.Add(this.tbAddress);
            this.gbCreateAccount.Controls.Add(this.tbFirstName);
            this.gbCreateAccount.Controls.Add(this.label6);
            this.gbCreateAccount.Controls.Add(this.btnCreateAccount);
            this.gbCreateAccount.Controls.Add(this.label5);
            this.gbCreateAccount.Controls.Add(this.tbPassWord);
            this.gbCreateAccount.Controls.Add(this.tbEmail);
            this.gbCreateAccount.Controls.Add(this.label4);
            this.gbCreateAccount.Controls.Add(this.tbBankAccountId);
            this.gbCreateAccount.Controls.Add(this.tbLastName);
            this.gbCreateAccount.Controls.Add(this.label3);
            this.gbCreateAccount.Controls.Add(this.label2);
            this.gbCreateAccount.Location = new System.Drawing.Point(188, 27);
            this.gbCreateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.gbCreateAccount.Name = "gbCreateAccount";
            this.gbCreateAccount.Padding = new System.Windows.Forms.Padding(2);
            this.gbCreateAccount.Size = new System.Drawing.Size(243, 279);
            this.gbCreateAccount.TabIndex = 3;
            this.gbCreateAccount.TabStop = false;
            this.gbCreateAccount.Text = "Create Account";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(99, 196);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(100, 23);
            this.tbStatus.TabIndex = 16;
            this.tbStatus.Text = "Yes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Address:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(99, 140);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 23);
            this.tbAddress.TabIndex = 13;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(99, 81);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 23);
            this.tbFirstName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "FirstName:";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCreateAccount.Location = new System.Drawing.Point(134, 232);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(105, 43);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pass:";
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(99, 50);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(100, 23);
            this.tbPassWord.TabIndex = 9;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(99, 21);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 23);
            this.tbEmail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // tbBankAccountId
            // 
            this.tbBankAccountId.Location = new System.Drawing.Point(101, 168);
            this.tbBankAccountId.Margin = new System.Windows.Forms.Padding(2);
            this.tbBankAccountId.Name = "tbBankAccountId";
            this.tbBankAccountId.Size = new System.Drawing.Size(98, 23);
            this.tbBankAccountId.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(99, 109);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 23);
            this.tbLastName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bank Account : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name :";
            // 
            // gbVerifyAccount
            // 
            this.gbVerifyAccount.Controls.Add(this.btnCheck);
            this.gbVerifyAccount.Controls.Add(this.tbTicketNo);
            this.gbVerifyAccount.Controls.Add(this.lbTicketNo);
            this.gbVerifyAccount.Location = new System.Drawing.Point(2, 27);
            this.gbVerifyAccount.Margin = new System.Windows.Forms.Padding(2);
            this.gbVerifyAccount.Name = "gbVerifyAccount";
            this.gbVerifyAccount.Padding = new System.Windows.Forms.Padding(2);
            this.gbVerifyAccount.Size = new System.Drawing.Size(182, 279);
            this.gbVerifyAccount.TabIndex = 2;
            this.gbVerifyAccount.TabStop = false;
            this.gbVerifyAccount.Text = "Verify Account";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCheck.Location = new System.Drawing.Point(36, 207);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(94, 48);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check Account";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tbTicketNo
            // 
            this.tbTicketNo.Location = new System.Drawing.Point(75, 57);
            this.tbTicketNo.Margin = new System.Windows.Forms.Padding(2);
            this.tbTicketNo.Name = "tbTicketNo";
            this.tbTicketNo.Size = new System.Drawing.Size(76, 23);
            this.tbTicketNo.TabIndex = 1;
            // 
            // lbTicketNo
            // 
            this.lbTicketNo.AutoSize = true;
            this.lbTicketNo.Location = new System.Drawing.Point(4, 57);
            this.lbTicketNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTicketNo.Name = "lbTicketNo";
            this.lbTicketNo.Size = new System.Drawing.Size(74, 17);
            this.lbTicketNo.TabIndex = 0;
            this.lbTicketNo.Text = "Ticket no: ";
            // 
            // rbTicketSale
            // 
            this.rbTicketSale.AutoSize = true;
            this.rbTicketSale.Location = new System.Drawing.Point(243, 2);
            this.rbTicketSale.Margin = new System.Windows.Forms.Padding(2);
            this.rbTicketSale.Name = "rbTicketSale";
            this.rbTicketSale.Size = new System.Drawing.Size(96, 21);
            this.rbTicketSale.TabIndex = 1;
            this.rbTicketSale.TabStop = true;
            this.rbTicketSale.Text = "Ticket Sale";
            this.rbTicketSale.UseVisualStyleBackColor = true;
            this.rbTicketSale.CheckedChanged += new System.EventHandler(this.tbTicketSale_CheckedChanged);
            // 
            // rbTicketExchange
            // 
            this.rbTicketExchange.AutoSize = true;
            this.rbTicketExchange.Location = new System.Drawing.Point(38, 2);
            this.rbTicketExchange.Margin = new System.Windows.Forms.Padding(2);
            this.rbTicketExchange.Name = "rbTicketExchange";
            this.rbTicketExchange.Size = new System.Drawing.Size(130, 21);
            this.rbTicketExchange.TabIndex = 0;
            this.rbTicketExchange.TabStop = true;
            this.rbTicketExchange.Text = "Ticket Exchange";
            this.rbTicketExchange.UseVisualStyleBackColor = true;
            this.rbTicketExchange.CheckedChanged += new System.EventHandler(this.rbTicketExchange_CheckedChanged);
            // 
            // gbRFID
            // 
            this.gbRFID.Controls.Add(this.lbSerialNo);
            this.gbRFID.Controls.Add(this.lblDeviceStatus);
            this.gbRFID.Controls.Add(this.lblValidRFIDNo);
            this.gbRFID.Controls.Add(this.btnBindToAccount);
            this.gbRFID.Controls.Add(this.btnOpenRFID);
            this.gbRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRFID.Location = new System.Drawing.Point(153, 388);
            this.gbRFID.Margin = new System.Windows.Forms.Padding(2);
            this.gbRFID.Name = "gbRFID";
            this.gbRFID.Padding = new System.Windows.Forms.Padding(2);
            this.gbRFID.Size = new System.Drawing.Size(404, 142);
            this.gbRFID.TabIndex = 3;
            this.gbRFID.TabStop = false;
            this.gbRFID.Text = "RFID Bind Account";
            // 
            // lbSerialNo
            // 
            this.lbSerialNo.AutoSize = true;
            this.lbSerialNo.Location = new System.Drawing.Point(188, 33);
            this.lbSerialNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSerialNo.Name = "lbSerialNo";
            this.lbSerialNo.Size = new System.Drawing.Size(141, 17);
            this.lbSerialNo.TabIndex = 4;
            this.lbSerialNo.Text = "Serial No :          XXX";
            // 
            // lblDeviceStatus
            // 
            this.lblDeviceStatus.AutoSize = true;
            this.lblDeviceStatus.Location = new System.Drawing.Point(188, 65);
            this.lblDeviceStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeviceStatus.Name = "lblDeviceStatus";
            this.lblDeviceStatus.Size = new System.Drawing.Size(142, 17);
            this.lblDeviceStatus.TabIndex = 3;
            this.lblDeviceStatus.Text = "Device Status :   XXX";
            // 
            // lblValidRFIDNo
            // 
            this.lblValidRFIDNo.AutoSize = true;
            this.lblValidRFIDNo.Location = new System.Drawing.Point(188, 96);
            this.lblValidRFIDNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValidRFIDNo.Name = "lblValidRFIDNo";
            this.lblValidRFIDNo.Size = new System.Drawing.Size(143, 17);
            this.lblValidRFIDNo.TabIndex = 2;
            this.lblValidRFIDNo.Text = "Valid RFID No :   XXX";
            // 
            // btnBindToAccount
            // 
            this.btnBindToAccount.Location = new System.Drawing.Point(10, 89);
            this.btnBindToAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnBindToAccount.Name = "btnBindToAccount";
            this.btnBindToAccount.Size = new System.Drawing.Size(184, 34);

            this.btnBindToAccount.Size = new System.Drawing.Size(158, 28);

            this.btnBindToAccount.TabIndex = 1;
            this.btnBindToAccount.Text = "Bind To Account";
            this.btnBindToAccount.UseVisualStyleBackColor = true;
            // 
            // btnOpenRFID
            // 
            this.btnOpenRFID.Location = new System.Drawing.Point(10, 41);
            this.btnOpenRFID.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenRFID.Name = "btnOpenRFID";

            this.btnOpenRFID.Size = new System.Drawing.Size(184, 37);

            this.btnOpenRFID.Size = new System.Drawing.Size(158, 30);

            this.btnOpenRFID.TabIndex = 0;
            this.btnOpenRFID.Text = "Open RFID Reader (5s)";
            this.btnOpenRFID.UseVisualStyleBackColor = true;
            this.btnOpenRFID.Click += new System.EventHandler(this.btnOpenRFID_Click_1);
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.lbMessage);
            this.gbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMessage.Location = new System.Drawing.Point(490, 70);
            this.gbMessage.Margin = new System.Windows.Forms.Padding(2);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Padding = new System.Windows.Forms.Padding(2);
            this.gbMessage.Size = new System.Drawing.Size(202, 291);
            this.gbMessage.TabIndex = 5;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(55, 79);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 17);
            this.lbMessage.TabIndex = 0;
            // 
            // TicketServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(912, 668);
            this.ClientSize = new System.Drawing.Size(716, 541);

            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.gbRFID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TicketServiceForm";
            this.Text = "Ticket Service App";
            this.Load += new System.EventHandler(this.TicketServiceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbCreateAccount.ResumeLayout(false);
            this.gbCreateAccount.PerformLayout();
            this.gbVerifyAccount.ResumeLayout(false);
            this.gbVerifyAccount.PerformLayout();
            this.gbRFID.ResumeLayout(false);
            this.gbRFID.PerformLayout();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbCreateAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbVerifyAccount;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox tbTicketNo;
        private System.Windows.Forms.Label lbTicketNo;
        private System.Windows.Forms.RadioButton rbTicketSale;
        private System.Windows.Forms.RadioButton rbTicketExchange;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox tbBankAccountId;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.GroupBox gbRFID;
        private System.Windows.Forms.Label lbSerialNo;
        private System.Windows.Forms.Label lblDeviceStatus;
        private System.Windows.Forms.Label lblValidRFIDNo;
        private System.Windows.Forms.Button btnBindToAccount;
        private System.Windows.Forms.Button btnOpenRFID;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label8;
    }
}

