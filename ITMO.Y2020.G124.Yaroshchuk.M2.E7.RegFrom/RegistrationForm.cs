using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Year2020.Group124.Practice.Yaroshchuk.M2.E7.RegFrom
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Label lb1 = new Label();
                lb1.Location = new System.Drawing.Point(16, 96);
                lb1.Size = new System.Drawing.Size(32, 23);
                lb1.Name = "label1";
                lb1.TabIndex = 2;
                lb1.Text = "PIN2";
                groupBox1.Controls.Add(lb1);
                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(96, 96);
                txt.Size = new System.Drawing.Size(184, 20);
                txt.Name = "textboxx";
                txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);
            }
            else 
            {
                int lcv;
                lcv = groupBox1.Controls.Count;
                            while (lcv > 4)
                            {
                                groupBox1.Controls.RemoveAt(lcv - 1);
                                lcv -= 1;
                            }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Field Name may only contain letters.");
            }
            errorProvider1.SetError(textBox1, "Must be a letter.");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    if (!char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //        MessageBox.Show("Field PIN may only contain numbers.");
        //    }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == "")
            {
                e.Cancel = false;
            }
                    else
                    {
                            try
                            {
                                double.Parse(textBox2.Text);
                                e.Cancel = false;
                            }
                                catch
                                {
                                   e.Cancel = true;
                                     MessageBox.Show("Field PIN may only contain numbers.");
                                }
                    }
        }
    }
}
