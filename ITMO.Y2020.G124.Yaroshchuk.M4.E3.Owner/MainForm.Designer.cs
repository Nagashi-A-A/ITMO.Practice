namespace ITMO.Y2020.G124.Yaroshchuk.M4.E3.Owner
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
            this.textBoxF1 = new System.Windows.Forms.TextBox();
            this.GetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxF1
            // 
            this.textBoxF1.Location = new System.Drawing.Point(197, 190);
            this.textBoxF1.Name = "textBoxF1";
            this.textBoxF1.Size = new System.Drawing.Size(375, 20);
            this.textBoxF1.TabIndex = 0;
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(334, 301);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(75, 23);
            this.GetButton.TabIndex = 1;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.textBoxF1);
            this.Name = "MainForm";
            this.Text = "Owner Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxF1;
        private System.Windows.Forms.Button GetButton;
    }
}

