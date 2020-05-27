namespace CampingAuthorization
{
    partial class CampingAuthorizationForm
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
            this.gbGuestInformation = new System.Windows.Forms.GroupBox();
            this.lbName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbRFIDReader = new System.Windows.Forms.GroupBox();
            this.btnOpenConnection = new System.Windows.Forms.Button();
            this.lbRfidStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRfidSerialNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCamping = new System.Windows.Forms.Label();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEventId = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.gbGuestInformation.SuspendLayout();
            this.gbRFIDReader.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGuestInformation
            // 
            this.gbGuestInformation.Controls.Add(this.lbName);
            this.gbGuestInformation.Controls.Add(this.label5);
            this.gbGuestInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGuestInformation.Location = new System.Drawing.Point(16, 101);
            this.gbGuestInformation.Margin = new System.Windows.Forms.Padding(4);
            this.gbGuestInformation.Name = "gbGuestInformation";
            this.gbGuestInformation.Padding = new System.Windows.Forms.Padding(4);
            this.gbGuestInformation.Size = new System.Drawing.Size(336, 151);
            this.gbGuestInformation.TabIndex = 0;
            this.gbGuestInformation.TabStop = false;
            this.gbGuestInformation.Text = "Guest information";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(184, 66);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 24);
            this.lbName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // gbRFIDReader
            // 
            this.gbRFIDReader.Controls.Add(this.btnOpenConnection);
            this.gbRFIDReader.Controls.Add(this.lbRfidStatus);
            this.gbRFIDReader.Controls.Add(this.label3);
            this.gbRFIDReader.Controls.Add(this.lbRfidSerialNumber);
            this.gbRFIDReader.Controls.Add(this.label1);
            this.gbRFIDReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRFIDReader.Location = new System.Drawing.Point(409, 101);
            this.gbRFIDReader.Margin = new System.Windows.Forms.Padding(4);
            this.gbRFIDReader.Name = "gbRFIDReader";
            this.gbRFIDReader.Padding = new System.Windows.Forms.Padding(4);
            this.gbRFIDReader.Size = new System.Drawing.Size(359, 328);
            this.gbRFIDReader.TabIndex = 1;
            this.gbRFIDReader.TabStop = false;
            this.gbRFIDReader.Text = "RFID Reader";
            // 
            // btnOpenConnection
            // 
            this.btnOpenConnection.Location = new System.Drawing.Point(43, 249);
            this.btnOpenConnection.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenConnection.Name = "btnOpenConnection";
            this.btnOpenConnection.Size = new System.Drawing.Size(265, 42);
            this.btnOpenConnection.TabIndex = 4;
            this.btnOpenConnection.Text = "Open RFID connection";
            this.btnOpenConnection.UseVisualStyleBackColor = true;
            this.btnOpenConnection.Click += new System.EventHandler(this.btnOpenConnection_Click);
            // 
            // lbRfidStatus
            // 
            this.lbRfidStatus.AutoSize = true;
            this.lbRfidStatus.Location = new System.Drawing.Point(191, 127);
            this.lbRfidStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRfidStatus.Name = "lbRfidStatus";
            this.lbRfidStatus.Size = new System.Drawing.Size(40, 24);
            this.lbRfidStatus.TabIndex = 3;
            this.lbRfidStatus.Text = "xxx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Status:";
            // 
            // lbRfidSerialNumber
            // 
            this.lbRfidSerialNumber.AutoSize = true;
            this.lbRfidSerialNumber.Location = new System.Drawing.Point(191, 62);
            this.lbRfidSerialNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRfidSerialNumber.Name = "lbRfidSerialNumber";
            this.lbRfidSerialNumber.Size = new System.Drawing.Size(40, 24);
            this.lbRfidSerialNumber.TabIndex = 1;
            this.lbRfidSerialNumber.Text = "xxx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SerialNo:";
            // 
            // lbCamping
            // 
            this.lbCamping.AutoSize = true;
            this.lbCamping.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamping.Location = new System.Drawing.Point(37, 23);
            this.lbCamping.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCamping.Name = "lbCamping";
            this.lbCamping.Size = new System.Drawing.Size(217, 54);
            this.lbCamping.TabIndex = 2;
            this.lbCamping.Text = "Camping";
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.lbStatus);
            this.gbMessage.Location = new System.Drawing.Point(16, 341);
            this.gbMessage.Margin = new System.Windows.Forms.Padding(4);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Padding = new System.Windows.Forms.Padding(4);
            this.gbMessage.Size = new System.Drawing.Size(336, 88);
            this.gbMessage.TabIndex = 3;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbStatus.Location = new System.Drawing.Point(35, 34);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 20);
            this.lbStatus.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Event id:";
            // 
            // lbEventId
            // 
            this.lbEventId.AutoSize = true;
            this.lbEventId.Location = new System.Drawing.Point(545, 33);
            this.lbEventId.Name = "lbEventId";
            this.lbEventId.Size = new System.Drawing.Size(0, 17);
            this.lbEventId.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(133, 278);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(102, 56);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // CampingAuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 442);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lbEventId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.lbCamping);
            this.Controls.Add(this.gbRFIDReader);
            this.Controls.Add(this.gbGuestInformation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CampingAuthorizationForm";
            this.Text = "FormCampingCheck";
            this.gbGuestInformation.ResumeLayout(false);
            this.gbGuestInformation.PerformLayout();
            this.gbRFIDReader.ResumeLayout(false);
            this.gbRFIDReader.PerformLayout();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGuestInformation;
        private System.Windows.Forms.GroupBox gbRFIDReader;
        private System.Windows.Forms.Label lbCamping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRfidSerialNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRfidStatus;
        private System.Windows.Forms.Button btnOpenConnection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEventId;
        private System.Windows.Forms.Button btnCheck;
    }
}

