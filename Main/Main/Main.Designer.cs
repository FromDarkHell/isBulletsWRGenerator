namespace Main
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.WRLabel = new System.Windows.Forms.Label();
            this.WRText = new System.Windows.Forms.Label();
            this.Butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WRLabel
            // 
            this.WRLabel.AutoSize = true;
            this.WRLabel.Font = new System.Drawing.Font("Revue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WRLabel.Location = new System.Drawing.Point(87, 0);
            this.WRLabel.Name = "WRLabel";
            this.WRLabel.Size = new System.Drawing.Size(82, 41);
            this.WRLabel.TabIndex = 0;
            this.WRLabel.Text = "WR:";
            // 
            // WRText
            // 
            this.WRText.AutoSize = true;
            this.WRText.Font = new System.Drawing.Font("Revue", 55F);
            this.WRText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.WRText.Location = new System.Drawing.Point(1, 62);
            this.WRText.Name = "WRText";
            this.WRText.Size = new System.Drawing.Size(181, 95);
            this.WRText.TabIndex = 1;
            this.WRText.Text = "Null";
            // 
            // Butt
            // 
            this.Butt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Butt.Font = new System.Drawing.Font("Revue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Butt.Location = new System.Drawing.Point(-4, 197);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(301, 74);
            this.Butt.TabIndex = 2;
            this.Butt.Text = "Find WR";
            this.Butt.UseVisualStyleBackColor = false;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(295, 270);
            this.Controls.Add(this.Butt);
            this.Controls.Add(this.WRText);
            this.Controls.Add(this.WRLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "isBullets Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WRLabel;
        private System.Windows.Forms.Label WRText;
        private System.Windows.Forms.Button Butt;
    }
}

