namespace Ticket_Service
{
    partial class LogInEmployeeForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmployeeId = new System.Windows.Forms.TextBox();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.btLogIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAvailableEvent = new System.Windows.Forms.ListBox();
            this.btChooseEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // tbEmployeeId
            // 
            this.tbEmployeeId.Location = new System.Drawing.Point(352, 164);
            this.tbEmployeeId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmployeeId.Name = "tbEmployeeId";
            this.tbEmployeeId.Size = new System.Drawing.Size(132, 22);
            this.tbEmployeeId.TabIndex = 3;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(352, 208);
            this.tbPassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '*';
            this.tbPassWord.Size = new System.Drawing.Size(132, 22);
            this.tbPassWord.TabIndex = 4;
            // 
            // btLogIn
            // 
            this.btLogIn.Enabled = false;
            this.btLogIn.Location = new System.Drawing.Point(335, 282);
            this.btLogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(151, 57);
            this.btLogIn.TabIndex = 5;
            this.btLogIn.Text = "Log In";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(704, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Choose an event:";
            // 
            // lbAvailableEvent
            // 
            this.lbAvailableEvent.FormattingEnabled = true;
            this.lbAvailableEvent.ItemHeight = 16;
            this.lbAvailableEvent.Location = new System.Drawing.Point(620, 133);
            this.lbAvailableEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbAvailableEvent.Name = "lbAvailableEvent";
            this.lbAvailableEvent.Size = new System.Drawing.Size(392, 244);
            this.lbAvailableEvent.TabIndex = 7;
            // 
            // btChooseEvent
            // 
            this.btChooseEvent.Location = new System.Drawing.Point(757, 426);
            this.btChooseEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btChooseEvent.Name = "btChooseEvent";
            this.btChooseEvent.Size = new System.Drawing.Size(139, 48);
            this.btChooseEvent.TabIndex = 8;
            this.btChooseEvent.Text = "Choose";
            this.btChooseEvent.UseVisualStyleBackColor = true;
            this.btChooseEvent.Click += new System.EventHandler(this.btChooseEvent_Click);
            // 
            // LogInEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btChooseEvent);
            this.Controls.Add(this.lbAvailableEvent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.tbPassWord);
            this.Controls.Add(this.tbEmployeeId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LogInEmployeeForm";
            this.Text = "LogInEmployee";
            this.Load += new System.EventHandler(this.LogInEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmployeeId;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbAvailableEvent;
        private System.Windows.Forms.Button btChooseEvent;
    }
}