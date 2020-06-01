namespace ITMO.Y2020.G124.Yaroshchuk.M5.E3.Chart
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TemperatureRadioButton = new System.Windows.Forms.RadioButton();
            this.HumidityRadioButton = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(26, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 333);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(14, 16);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TemperatureRadioButton);
            this.groupBox1.Controls.Add(this.HumidityRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(386, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // TemperatureRadioButton
            // 
            this.TemperatureRadioButton.AutoSize = true;
            this.TemperatureRadioButton.Location = new System.Drawing.Point(18, 54);
            this.TemperatureRadioButton.Name = "TemperatureRadioButton";
            this.TemperatureRadioButton.Size = new System.Drawing.Size(85, 17);
            this.TemperatureRadioButton.TabIndex = 1;
            this.TemperatureRadioButton.TabStop = true;
            this.TemperatureRadioButton.Text = "Temperature";
            this.TemperatureRadioButton.UseVisualStyleBackColor = true;
            this.TemperatureRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // HumidityRadioButton
            // 
            this.HumidityRadioButton.AutoSize = true;
            this.HumidityRadioButton.Location = new System.Drawing.Point(18, 30);
            this.HumidityRadioButton.Name = "HumidityRadioButton";
            this.HumidityRadioButton.Size = new System.Drawing.Size(65, 17);
            this.HumidityRadioButton.TabIndex = 0;
            this.HumidityRadioButton.TabStop = true;
            this.HumidityRadioButton.Text = "Humidity";
            this.HumidityRadioButton.UseVisualStyleBackColor = true;
            this.HumidityRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 364);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Column Chart Type";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 407);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ChartForm";
            this.Text = "Chart Test Form";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton TemperatureRadioButton;
        private System.Windows.Forms.RadioButton HumidityRadioButton;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

