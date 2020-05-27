namespace ExitEvent
{
    partial class LogInEmployeeFormExitEvent
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
            this.btChooseEvent = new System.Windows.Forms.Button();
            this.lbAvailableEvents = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btLogIn = new System.Windows.Forms.Button();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.tbEmployeeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btChooseEvent
            // 
            this.btChooseEvent.Location = new System.Drawing.Point(559, 402);
            this.btChooseEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btChooseEvent.Name = "btChooseEvent";
            this.btChooseEvent.Size = new System.Drawing.Size(131, 36);
            this.btChooseEvent.TabIndex = 26;
            this.btChooseEvent.Text = "Choose";
            this.btChooseEvent.UseVisualStyleBackColor = true;
            // 
            // lbAvailableEvents
            // 
            this.lbAvailableEvents.FormattingEnabled = true;
            this.lbAvailableEvents.ItemHeight = 16;
            this.lbAvailableEvents.Location = new System.Drawing.Point(427, 118);
            this.lbAvailableEvents.Margin = new System.Windows.Forms.Padding(4);
            this.lbAvailableEvents.Name = "lbAvailableEvents";
            this.lbAvailableEvents.Size = new System.Drawing.Size(389, 260);
            this.lbAvailableEvents.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Choose an Event:";
            // 
            // btLogIn
            // 
            this.btLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogIn.Location = new System.Drawing.Point(113, 262);
            this.btLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(167, 46);
            this.btLogIn.TabIndex = 23;
            this.btLogIn.Text = "Log In";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click_1);
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(163, 189);
            this.tbPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '*';
            this.tbPassWord.Size = new System.Drawing.Size(132, 22);
            this.tbPassWord.TabIndex = 22;
            // 
            // tbEmployeeId
            // 
            this.tbEmployeeId.Location = new System.Drawing.Point(163, 133);
            this.tbEmployeeId.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmployeeId.Name = "tbEmployeeId";
            this.tbEmployeeId.Size = new System.Drawing.Size(132, 22);
            this.tbEmployeeId.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "EmployeeId:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Log In";
            // 
            // LogInEmployeeFormExitEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 537);
            this.Controls.Add(this.btChooseEvent);
            this.Controls.Add(this.lbAvailableEvents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.tbPassWord);
            this.Controls.Add(this.tbEmployeeId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogInEmployeeFormExitEvent";
            this.Text = "LogInEmployeeForm";
            this.Load += new System.EventHandler(this.LogInEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btChooseEvent;
        private System.Windows.Forms.ListBox lbAvailableEvents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.TextBox tbEmployeeId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}