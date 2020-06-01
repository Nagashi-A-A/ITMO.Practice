using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Year2020.Group124.Practice.Yaroshchuk._5._2.RhombusForm
{
    public partial class RhombusForm : Form
    {
        public RhombusForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(this.Width/2, 0), new Point(0, this.Width / 2), new Point(this.Width, this.Width/2) });
            myPath.AddPolygon(new Point[] { new Point(0, this.Width / 2), new Point(this.Width, this.Width / 2), new Point(this.Width/2, this.Width) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        private void PeaceButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
