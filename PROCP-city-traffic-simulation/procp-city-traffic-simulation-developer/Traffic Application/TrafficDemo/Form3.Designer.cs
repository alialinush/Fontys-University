namespace TrafficDemo
{
    partial class Form3
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tbTrafficLightTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbRoad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(604, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 65);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbTrafficLightTime
            // 
            this.tbTrafficLightTime.Location = new System.Drawing.Point(664, 182);
            this.tbTrafficLightTime.Name = "tbTrafficLightTime";
            this.tbTrafficLightTime.Size = new System.Drawing.Size(113, 22);
            this.tbTrafficLightTime.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Set traffic light time:";
            // 
            // pbRoad
            // 
            this.pbRoad.Location = new System.Drawing.Point(24, 12);
            this.pbRoad.Name = "pbRoad";
            this.pbRoad.Size = new System.Drawing.Size(466, 453);
            this.pbRoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoad.TabIndex = 8;
            this.pbRoad.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 484);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbTrafficLightTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRoad);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pbRoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbTrafficLightTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbRoad;
    }
}