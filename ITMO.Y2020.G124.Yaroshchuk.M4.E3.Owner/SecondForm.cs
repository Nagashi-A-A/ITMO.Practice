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
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string comboString = textBoxF21.Text + " " + textBoxF22.Text + " " + textBoxF23.Text;
            MainForm formOne = this.Owner as MainForm;
            if (formOne != null)
            {
                formOne.SolData = comboString;
            }
            this.Close();
        }
    }
}
