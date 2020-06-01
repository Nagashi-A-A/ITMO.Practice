﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Year2020.Group124.Practice.Yaroshchuk._5._1.FormEllipse
{
    public partial class EllipseForm : Form
    {
        public EllipseForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(new Rectangle(0, 0, this.Width, this.Height));
            Region myRegion = new Region(myPath);
            this.Region = myRegion;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
