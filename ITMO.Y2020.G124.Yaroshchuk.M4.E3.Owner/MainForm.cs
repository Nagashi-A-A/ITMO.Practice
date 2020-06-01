using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Y2020.G124.Yaroshchuk.M4.E3.Owner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string SolData
        {
            get
            {
                return textBoxF1.Text;
            }
            set
            {
                textBoxF1.Text = value;
            }
        }

        private void GetButton_Click(object sender, EventArgs e)
        {
            SecondForm createFormTwo = new SecondForm();
            createFormTwo.Show(this);
        }
    }
}
