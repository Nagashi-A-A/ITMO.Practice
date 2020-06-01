namespace ITMO.Year2020.Group124.Practice.Yaroshchuk._5._2.RhombusForm
{
    partial class RhombusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RhombusForm));
            this.PeaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeaceButton
            // 
            this.PeaceButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PeaceButton.Image = ((System.Drawing.Image)(resources.GetObject("PeaceButton.Image")));
            this.PeaceButton.Location = new System.Drawing.Point(315, 342);
            this.PeaceButton.Name = "PeaceButton";
            this.PeaceButton.Size = new System.Drawing.Size(157, 95);
            this.PeaceButton.TabIndex = 0;
            this.PeaceButton.UseVisualStyleBackColor = true;
            this.PeaceButton.Click += new System.EventHandler(this.PeaceButton_Click);
            // 
            // RhombusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 799);
            this.Controls.Add(this.PeaceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RhombusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rhombus Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PeaceButton;
    }
}

