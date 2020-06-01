namespace ITMO.Y2020.G124.Yaroshchuk.M4.E3.WinAnim
{
    partial class AniMainForm
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
            this.btnAwBlend = new System.Windows.Forms.Button();
            this.btnHorAwSlide = new System.Windows.Forms.Button();
            this.btnCenterAwSlide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAwBlend
            // 
            this.btnAwBlend.Location = new System.Drawing.Point(54, 68);
            this.btnAwBlend.Name = "btnAwBlend";
            this.btnAwBlend.Size = new System.Drawing.Size(98, 36);
            this.btnAwBlend.TabIndex = 0;
            this.btnAwBlend.Text = "Manifestation";
            this.btnAwBlend.UseVisualStyleBackColor = true;
            this.btnAwBlend.Click += new System.EventHandler(this.btnAwBlend_Click);
            // 
            // btnHorAwSlide
            // 
            this.btnHorAwSlide.Location = new System.Drawing.Point(54, 137);
            this.btnHorAwSlide.Name = "btnHorAwSlide";
            this.btnHorAwSlide.Size = new System.Drawing.Size(98, 37);
            this.btnHorAwSlide.TabIndex = 1;
            this.btnHorAwSlide.Text = "Horizontal Manifestation";
            this.btnHorAwSlide.UseVisualStyleBackColor = true;
            this.btnHorAwSlide.Click += new System.EventHandler(this.btnHorAwSlide_Click);
            // 
            // btnCenterAwSlide
            // 
            this.btnCenterAwSlide.Location = new System.Drawing.Point(54, 204);
            this.btnCenterAwSlide.Name = "btnCenterAwSlide";
            this.btnCenterAwSlide.Size = new System.Drawing.Size(98, 39);
            this.btnCenterAwSlide.TabIndex = 2;
            this.btnCenterAwSlide.Text = "Center Manifestation";
            this.btnCenterAwSlide.UseVisualStyleBackColor = true;
            this.btnCenterAwSlide.Click += new System.EventHandler(this.btnCenterAwSlide_Click);
            // 
            // AniMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.btnCenterAwSlide);
            this.Controls.Add(this.btnHorAwSlide);
            this.Controls.Add(this.btnAwBlend);
            this.Name = "AniMainForm";
            this.Text = "Form Animation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAwBlend;
        private System.Windows.Forms.Button btnHorAwSlide;
        private System.Windows.Forms.Button btnCenterAwSlide;
    }
}

