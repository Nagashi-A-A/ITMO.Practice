namespace ITMO.Y2020.G124.Yaroshchuk.TestExamAlgo
{
    partial class TestMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestMainForm));
            this.AddBox = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelAdd = new System.Windows.Forms.Label();
            this.ResultButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.EqualCheckResult = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddBox
            // 
            this.AddBox.BackColor = System.Drawing.Color.Wheat;
            this.AddBox.Location = new System.Drawing.Point(12, 73);
            this.AddBox.Name = "AddBox";
            this.AddBox.Size = new System.Drawing.Size(321, 20);
            this.AddBox.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonAdd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(351, 70);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.BackColor = System.Drawing.Color.Transparent;
            this.labelAdd.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAdd.Location = new System.Drawing.Point(12, 47);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(321, 21);
            this.labelAdd.TabIndex = 2;
            this.labelAdd.Text = "Please input strings for equivalence check:";
            // 
            // ResultButton
            // 
            this.ResultButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ResultButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultButton.Location = new System.Drawing.Point(149, 136);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(184, 32);
            this.ResultButton.TabIndex = 3;
            this.ResultButton.Text = " Equivalence Check";
            this.ResultButton.UseVisualStyleBackColor = false;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Wheat;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(64, 205);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(371, 325);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // EqualCheckResult
            // 
            this.EqualCheckResult.AutoSize = true;
            this.EqualCheckResult.BackColor = System.Drawing.Color.Transparent;
            this.EqualCheckResult.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqualCheckResult.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EqualCheckResult.Location = new System.Drawing.Point(60, 181);
            this.EqualCheckResult.Name = "EqualCheckResult";
            this.EqualCheckResult.Size = new System.Drawing.Size(97, 21);
            this.EqualCheckResult.TabIndex = 5;
            this.EqualCheckResult.Text = "Strings list:";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.BurlyWood;
            this.ClearButton.Location = new System.Drawing.Point(351, 100);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.Wheat;
            this.richTextBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(11, 205);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(47, 324);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "№";
            // 
            // TestMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(442, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EqualCheckResult);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.labelAdd);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.AddBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestMainForm";
            this.Text = " Equivalence Check Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label EqualCheckResult;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
    }
}

