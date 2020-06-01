namespace ITMO.Y2020.G124.Yaroshchuk.M4.E3.Owner
{
    partial class SecondForm
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
            this.textBoxF21 = new System.Windows.Forms.TextBox();
            this.textBoxF22 = new System.Windows.Forms.TextBox();
            this.textBoxF23 = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxF21
            // 
            this.textBoxF21.Location = new System.Drawing.Point(42, 29);
            this.textBoxF21.Name = "textBoxF21";
            this.textBoxF21.Size = new System.Drawing.Size(699, 20);
            this.textBoxF21.TabIndex = 0;
            // 
            // textBoxF22
            // 
            this.textBoxF22.Location = new System.Drawing.Point(42, 80);
            this.textBoxF22.Name = "textBoxF22";
            this.textBoxF22.Size = new System.Drawing.Size(699, 20);
            this.textBoxF22.TabIndex = 1;
            // 
            // textBoxF23
            // 
            this.textBoxF23.Location = new System.Drawing.Point(42, 127);
            this.textBoxF23.Name = "textBoxF23";
            this.textBoxF23.Size = new System.Drawing.Size(699, 20);
            this.textBoxF23.TabIndex = 2;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(251, 192);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(214, 23);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.textBoxF23);
            this.Controls.Add(this.textBoxF22);
            this.Controls.Add(this.textBoxF21);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxF21;
        private System.Windows.Forms.TextBox textBoxF22;
        private System.Windows.Forms.TextBox textBoxF23;
        private System.Windows.Forms.Button SendButton;
    }
}