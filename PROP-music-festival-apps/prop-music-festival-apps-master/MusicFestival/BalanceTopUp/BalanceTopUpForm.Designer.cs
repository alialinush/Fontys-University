namespace balance_top_up
{
    partial class BalanceTopUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BalanceTopUpForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxTopUp = new System.Windows.Forms.ListBox();
            this.btnCfmTop = new System.Windows.Forms.Button();
            this.pbxSign = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSign)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 61);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "BALANCE TOP-UP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(126, 95);
            this.btnLoadFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(234, 42);
            this.btnLoadFile.TabIndex = 2;
            this.btnLoadFile.Text = "Load Your File Here";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Accounts Of Transaction :";
            // 
            // lbxTopUp
            // 
            this.lbxTopUp.FormattingEnabled = true;
            this.lbxTopUp.Location = new System.Drawing.Point(126, 169);
            this.lbxTopUp.Margin = new System.Windows.Forms.Padding(2);
            this.lbxTopUp.Name = "lbxTopUp";
            this.lbxTopUp.Size = new System.Drawing.Size(236, 173);
            this.lbxTopUp.TabIndex = 4;
            this.lbxTopUp.SelectedIndexChanged += new System.EventHandler(this.lbTransactions_SelectedIndexChanged);
            // 
            // btnCfmTop
            // 
            this.btnCfmTop.Location = new System.Drawing.Point(126, 358);
            this.btnCfmTop.Margin = new System.Windows.Forms.Padding(2);
            this.btnCfmTop.Name = "btnCfmTop";
            this.btnCfmTop.Size = new System.Drawing.Size(234, 41);
            this.btnCfmTop.TabIndex = 5;
            this.btnCfmTop.Text = "TOP UP";
            this.btnCfmTop.UseVisualStyleBackColor = true;
            // 
            // pbxSign
            // 
            this.pbxSign.BackColor = System.Drawing.SystemColors.Control;
            this.pbxSign.Location = new System.Drawing.Point(399, 199);
            this.pbxSign.Margin = new System.Windows.Forms.Padding(2);
            this.pbxSign.Name = "pbxSign";
            this.pbxSign.Size = new System.Drawing.Size(75, 81);
            this.pbxSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSign.TabIndex = 37;
            this.pbxSign.TabStop = false;
            // 
            // BalanceTopUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 409);
            this.Controls.Add(this.pbxSign);
            this.Controls.Add(this.btnCfmTop);
            this.Controls.Add(this.lbxTopUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BalanceTopUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxTopUp;
        private System.Windows.Forms.Button btnCfmTop;
        private System.Windows.Forms.PictureBox pbxSign;
    }
}

