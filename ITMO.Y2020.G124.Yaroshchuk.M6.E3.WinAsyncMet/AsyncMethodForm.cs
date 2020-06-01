using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Y2020.G124.Yaroshchuk.M6.E3.WinAsyncMet
{
    public partial class AsyncMethodForm : Form
    {
        public AsyncMethodForm()
        {
            InitializeComponent();
        }

        private delegate int AsyncSumm(int a, int b);

        private int Summ(int a, int b)
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSumm summdelegate = (AsyncSumm)ar.AsyncState;
            str = String.Format("Sum of A and B is: {0}.", summdelegate.EndInvoke(ar));
            MessageBox.Show(str, "Operation result:");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(txbA.Text);
                b = Int32.Parse(txbB.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("An error occurred while performing type conversion.");
                txbA.Text = txbB.Text = " ";
                return;
            }

            AsyncSumm summdelegate = new AsyncSumm(Summ);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);
            summdelegate.BeginInvoke(a, b, cb, summdelegate);
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work is in full swing!");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }
    }
}
