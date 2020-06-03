using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITMO.Y2020.G124.Yaroshchuk.WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 1;
        List<string> stringsToCheck = new List<string>();
        List<string> stringsCount = new List<string>();
        StringBuilder nStnBuild = new StringBuilder();
        public MainWindow()
        {
            InitializeComponent();
            AddStringBox.Clear();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            stringsToCheck.Add(AddStringBox.Text);
            stringsCount.Add("№" + count.ToString());
                nStnBuild.AppendFormat("{0}  {1}", stringsCount[count-1], stringsToCheck[count-1]);
                nStnBuild.AppendLine();
            StringsCheckBox.AppendText(nStnBuild.ToString());
            nStnBuild.Clear();
            count++;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringsCheckBox.Document.Blocks.Clear();
            AddStringBox.Clear();
            stringsToCheck.Clear();
            stringsCount.Clear();
            count = 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HashAndCheck msgBox = new HashAndCheck(stringsToCheck);
            if (msgBox.finalMessage != null)
                MessageBox.Show(msgBox.finalMessage);
            else
                MessageBox.Show("There aren't any equal strings.");
        }
    }
}
