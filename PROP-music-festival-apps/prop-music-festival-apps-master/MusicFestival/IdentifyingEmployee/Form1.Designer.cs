namespace IdentifyingEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmployeeNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbWorkplaces = new System.Windows.Forms.ListBox();
            this.btnConfirmWorkplace = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmployeeFirstName = new System.Windows.Forms.Label();
            this.lblEmployeeLastName = new System.Windows.Forms.Label();
            this.pbMessage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifying Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Number :";
            // 
            // tbEmployeeNo
            // 
            this.tbEmployeeNo.Location = new System.Drawing.Point(181, 109);
            this.tbEmployeeNo.Name = "tbEmployeeNo";
            this.tbEmployeeNo.Size = new System.Drawing.Size(100, 22);
            this.tbEmployeeNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select your current workplace :";
            // 
            // lbWorkplaces
            // 
            this.lbWorkplaces.FormattingEnabled = true;
            this.lbWorkplaces.ItemHeight = 16;
            this.lbWorkplaces.Location = new System.Drawing.Point(46, 192);
            this.lbWorkplaces.Name = "lbWorkplaces";
            this.lbWorkplaces.Size = new System.Drawing.Size(235, 228);
            this.lbWorkplaces.TabIndex = 4;
            // 
            // btnConfirmWorkplace
            // 
            this.btnConfirmWorkplace.Location = new System.Drawing.Point(46, 439);
            this.btnConfirmWorkplace.Name = "btnConfirmWorkplace";
            this.btnConfirmWorkplace.Size = new System.Drawing.Size(235, 45);
            this.btnConfirmWorkplace.TabIndex = 5;
            this.btnConfirmWorkplace.Text = "Confirm your workplace";
            this.btnConfirmWorkplace.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Employee Information :";
            // 
            // lblEmployeeFirstName
            // 
            this.lblEmployeeFirstName.AutoSize = true;
            this.lblEmployeeFirstName.Location = new System.Drawing.Point(387, 192);
            this.lblEmployeeFirstName.Name = "lblEmployeeFirstName";
            this.lblEmployeeFirstName.Size = new System.Drawing.Size(189, 17);
            this.lblEmployeeFirstName.TabIndex = 7;
            this.lblEmployeeFirstName.Text = "Employee First Name :   XXX";
            // 
            // lblEmployeeLastName
            // 
            this.lblEmployeeLastName.AutoSize = true;
            this.lblEmployeeLastName.Location = new System.Drawing.Point(387, 253);
            this.lblEmployeeLastName.Name = "lblEmployeeLastName";
            this.lblEmployeeLastName.Size = new System.Drawing.Size(189, 17);
            this.lblEmployeeLastName.TabIndex = 8;
            this.lblEmployeeLastName.Text = "Employee Last Name :   XXX";
            // 
            // pbMessage
            // 
            this.pbMessage.Location = new System.Drawing.Point(390, 327);
            this.pbMessage.Name = "pbMessage";
            this.pbMessage.Size = new System.Drawing.Size(196, 127);
            this.pbMessage.TabIndex = 9;
            this.pbMessage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 522);
            this.Controls.Add(this.pbMessage);
            this.Controls.Add(this.lblEmployeeLastName);
            this.Controls.Add(this.lblEmployeeFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConfirmWorkplace);
            this.Controls.Add(this.lbWorkplaces);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmployeeNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmployeeNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbWorkplaces;
        private System.Windows.Forms.Button btnConfirmWorkplace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmployeeFirstName;
        private System.Windows.Forms.Label lblEmployeeLastName;
        private System.Windows.Forms.PictureBox pbMessage;
    }
}

