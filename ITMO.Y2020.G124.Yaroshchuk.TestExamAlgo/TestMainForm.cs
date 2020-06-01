using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Y2020.G124.Yaroshchuk.TestExamAlgo
{
    public partial class TestMainForm : Form
    {
        int count = 1;

        List<string> stringsToCheck = new List<string>();
        List<string> stringsCount = new List<string>();

        public TestMainForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            stringsToCheck.Add(AddBox.Text);
            stringsCount.Add("№" + count.ToString());
            richTextBox1.Lines = stringsToCheck.ToArray();
            richTextBox2.Lines = stringsCount.ToArray();
            count++;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            AddBox.Clear();
            stringsToCheck.Clear();
            stringsCount.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
            count = 1;
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            HashAndCheckEquals msgBox = new HashAndCheckEquals(stringsToCheck);
            if (msgBox.finalMessage != null)
                MessageBox.Show(msgBox.finalMessage);
            else
                MessageBox.Show("There aren't any equal strings.");
        }
    }
}
