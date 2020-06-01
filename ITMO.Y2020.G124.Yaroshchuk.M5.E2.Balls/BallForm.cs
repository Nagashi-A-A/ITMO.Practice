using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Y2020.G124.Yaroshchuk.M5.E2.Balls
{
    public partial class BallForm : Form
    {
        Point location = new Point(50, 50);
        Point speed = new Point(5, 5);

        private void Go()
        {
            location = new Point(location.X + speed.X, location.Y + speed.Y);

            if (location.X + 0 > ClientRectangle.Width || location.X < 0)
                speed = new Point(-speed.X, speed.Y);
            if (location.Y + 10 > ClientRectangle.Height || location.Y < 0)
                speed = new Point(speed.X, -speed.Y);
        }

        private void Ball()
        {
            Graphics gr = Graphics.FromHwnd(this.Handle);
            gr.FillEllipse(Brushes.MediumVioletRed, location.X, location.Y, 10, 10);
            Go();
        }

        public BallForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            Ball();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }
    }
}
