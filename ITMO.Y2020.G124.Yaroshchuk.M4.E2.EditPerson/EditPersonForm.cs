using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Y2020.G124.Yaroshchuk.M4.E2.EditPerson
{
    public partial class EditPersonForm : Form
    {
        Person p;

        public EditPersonForm(Person p)
        {
                InitializeComponent();

                this.p = p;
                this.FirstName = p.FirstName;
                this.LastName = p.LastName;
                this.Age = p.Age;
        }

        public string FirstName
        {
            get { return NameTextBox.Text; }
            set { NameTextBox.Text = value; }
        }

        public string LastName
        {
            get { return LastNameTextBox.Text; }
            set { LastNameTextBox.Text = value; }
        }

        public int Age
        {
            get { return (int)AgeNumeric.Value; }
            set { AgeNumeric.Value = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.FirstName = this.FirstName;
            p.LastName = this.LastName;
            p.Age = this.Age;

            MessageBox.Show("Employee: " + p.ToString());
        }
    }
}
