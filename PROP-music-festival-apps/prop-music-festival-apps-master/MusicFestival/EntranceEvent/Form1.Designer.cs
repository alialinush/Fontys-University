namespace EntranceEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTktnr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxSign = new System.Windows.Forms.PictureBox();
            this.lblGuest = new System.Windows.Forms.GroupBox();
            this.lblDevStatus = new System.Windows.Forms.Label();
            this.ilstSign = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSign)).BeginInit();
            this.lblGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "ENTRANCE";
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(20, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(82, 89);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 25;
            this.pbLogo.TabStop = false;
            // 
            // lblTktnr
            // 
            this.lblTktnr.AutoSize = true;
            this.lblTktnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTktnr.Location = new System.Drawing.Point(79, 63);
            this.lblTktnr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTktnr.Name = "lblTktnr";
            this.lblTktnr.Size = new System.Drawing.Size(63, 17);
            this.lblTktnr.TabIndex = 1;
            this.lblTktnr.Text = "lblTktnr";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ticket No.:";
            // 
            // pbxSign
            // 
            this.pbxSign.Location = new System.Drawing.Point(188, 23);
            this.pbxSign.Margin = new System.Windows.Forms.Padding(2);
            this.pbxSign.Name = "pbxSign";
            this.pbxSign.Size = new System.Drawing.Size(75, 81);
            this.pbxSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSign.TabIndex = 3;
            this.pbxSign.TabStop = false;
            // 
            // lblGuest
            // 
            this.lblGuest.Controls.Add(this.pbxSign);
            this.lblGuest.Controls.Add(this.label1);
            this.lblGuest.Controls.Add(this.lblTktnr);
            this.lblGuest.Location = new System.Drawing.Point(13, 123);
            this.lblGuest.Margin = new System.Windows.Forms.Padding(2);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Padding = new System.Windows.Forms.Padding(2);
            this.lblGuest.Size = new System.Drawing.Size(300, 122);
            this.lblGuest.TabIndex = 26;
            this.lblGuest.TabStop = false;
            this.lblGuest.Text = "Guest Info";
            // 
            // lblDevStatus
            // 
            this.lblDevStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDevStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevStatus.Location = new System.Drawing.Point(0, 0);
            this.lblDevStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDevStatus.Name = "lblDevStatus";
            this.lblDevStatus.Size = new System.Drawing.Size(800, 450);
            this.lblDevStatus.TabIndex = 24;
            this.lblDevStatus.Text = "lblDevStatus";
            this.lblDevStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ilstSign
            // 
            this.ilstSign.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilstSign.ImageStream")));
            this.ilstSign.TransparentColor = System.Drawing.Color.Transparent;
            this.ilstSign.Images.SetKeyName(0, "icon_wrong.png");
            this.ilstSign.Images.SetKeyName(1, "icon_correct.png");
            this.ilstSign.Images.SetKeyName(2, "icon_stop.png");
            this.ilstSign.Images.SetKeyName(3, "icon_enter.png");
            this.ilstSign.Images.SetKeyName(4, "icon_exit.png");
            // 
            // Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblDevStatus);
            this.Name = "Entrance";
            this.Text = "Entrance";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSign)).EndInit();
            this.lblGuest.ResumeLayout(false);
            this.lblGuest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTktnr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxSign;
        private System.Windows.Forms.GroupBox lblGuest;
        private System.Windows.Forms.Label lblDevStatus;
        private System.Windows.Forms.ImageList ilstSign;
    }
}