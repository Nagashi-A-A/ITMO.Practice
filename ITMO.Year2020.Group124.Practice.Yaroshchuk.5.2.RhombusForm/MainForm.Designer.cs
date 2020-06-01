namespace ITMO.Year2020.Group124.Practice.Yaroshchuk._5._2.RhombusForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BigGreenButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BigGreenButton
            // 
            this.BigGreenButton.AllowDrop = true;
            this.BigGreenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BigGreenButton.BackColor = System.Drawing.Color.Green;
            this.BigGreenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BigGreenButton.BackgroundImage")));
            this.BigGreenButton.ImageKey = "(none)";
            this.BigGreenButton.Location = new System.Drawing.Point(381, 61);
            this.BigGreenButton.Name = "BigGreenButton";
            this.BigGreenButton.Size = new System.Drawing.Size(227, 210);
            this.BigGreenButton.TabIndex = 1;
            this.BigGreenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BigGreenButton.UseVisualStyleBackColor = false;
            this.BigGreenButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(421, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 108);
            this.button1.TabIndex = 2;
            this.button1.Text = "!BOOM!";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1091, 664);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BigGreenButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BigGreenButton;
        private System.Windows.Forms.Button button1;
    }
}