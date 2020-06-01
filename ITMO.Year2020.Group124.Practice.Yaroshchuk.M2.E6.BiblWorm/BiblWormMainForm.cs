using MyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Year2020.Group124.Practice.Yaroshchuk.M2.E6.BiblWorm
{
    public partial class BiblWormMainForm : Form
    {
        public BiblWormMainForm()
        {
            InitializeComponent();
        }

        List<Item> itsBooks = new List<Item>();
        List<Item> itsMagz = new List<Item>();

        //Bookzones:

        public string Author
        {
            get { return authorBox.Text;}
            set { authorBox.Text = value; }
        }

        public string Title
        {
            get { return titleBox.Text; }
            set { titleBox.Text = value; }
        }

        public string PublishHouse
        {
            get { return publishBox.Text; }
            set { publishBox.Text = value; }
        }

        public int Page
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }

        public int Year
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }

        public int PeriodUse
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }

        public bool Existance
        {
            get { return AvailBox.Checked; }
            set { AvailBox.Checked = value; }
        }
        public bool sortInvNumber
        {
            get { return sortBox.Checked; }
            set { sortBox.Checked = value; }
        }
        public bool ReturnTime
        {
            get { return returnBox.Checked; }
            set { returnBox.Checked = value; }
        }

        //Magazones:

        public string Tome
        {
            get { return TomeTextBox.Text; }
            set { TomeTextBox.Text = value; }
        }

        public int MagNumber
        {
            get { return (int)MagNumberNum.Value; }
            set { MagNumberNum.Value = value; }
        }

        public string TitleMag
        {
            get { return TitleMagTextBox.Text; }
            set { TitleMagTextBox.Text = value; }
        }

        public int MagYear
        {
            get { return (int)MagYearNum.Value; }
            set { MagYearNum.Value = value; }
        }

        public int MagInvNumber
        {
            get { return (int)MagInvNumberNum.Value; }
            set { MagInvNumberNum.Value = value; }
        }

        public int MagPeriodUse
        {
            get { return (int)MagPeriodNum.Value; }
            set { MagPeriodNum.Value = value; }
        }

        public bool MagExistance
        {
            get { return MagAvailBox.Checked; }
            set { MagAvailBox.Checked = value; }
        }
        public bool MagSortInvNumber
        {
            get { return MagSortBox.Checked; }
            set { MagSortBox.Checked = value; }
        }
        public bool MagReturnTime
        {
            get { return MagReturnBox.Checked; }
            set { MagReturnBox.Checked = value; }
        }

        //BooksMainZone:

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse, Page, Year, InvNumber, Existance);
            if (ReturnTime)
                b.ReturnSrok();
                    b.PriceBook(PeriodUse);
            itsBooks.Add(b);
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 1800;
            Existance = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sortInvNumber)
                itsBooks.Sort();
            StringBuilder sb = new StringBuilder();
                foreach (Item item in itsBooks)
                {
                    sb.Append("\n" + item.ToString());
                }
            richTextBox1.Text = sb.ToString();
        }

        //MagMainZone:

        private void button4_Click(object sender, EventArgs e)
        {
            Magazine newM = new Magazine(Tome, MagNumber, TitleMag, MagYear, MagInvNumber, MagExistance);
            if (MagReturnTime)
                newM.ReturnSrok();
            newM.PriceMag(MagPeriodUse);
            itsMagz.Add(newM);
            Tome = TitleMag = "";
            MagNumber = MagInvNumber = MagPeriodUse = 0;
            MagYear = 1800;
            MagExistance = MagReturnTime = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MagSortInvNumber)
                itsMagz.Sort();
            StringBuilder sbMagz = new StringBuilder();
            foreach (Item item in itsMagz)
            {
                sbMagz.Append("\n" + item.ToString());
            }
            MagRichTextBox.Text = sbMagz.ToString();
        }
    }
}
