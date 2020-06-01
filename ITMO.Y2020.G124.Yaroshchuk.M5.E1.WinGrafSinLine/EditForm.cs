using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Y2020.G124.Yaroshchuk.M5.E1.WinGrafSinLine
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frmOne = this.Owner as Form1;
                try
                {
                frmOne.aFirst = double.Parse(textBox1.Text);
                frmOne.bSecond = double.Parse(textBox2.Text);
                }
                catch (Exception er)
                {
                    MessageBox.Show("An error occurred while performing input: \n" + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Close();
                frmOne.Refresh();
        }
    }
}
