using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ITMO.Y2020.G124.Yaroshchuk.M4.E2.EditPerson
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<Person> pers = new List<Person>();

        private void AddButton_Click(object sender, EventArgs e)
        {
            Person pEmployee = new Person();
            EditPersonForm editForm = new EditPersonForm(pEmployee);
                 if (editForm.ShowDialog() != DialogResult.OK)
                    return;
            pers.Add(pEmployee);

            //ListViewItem newItem = personsListView.Items.Add(editForm.FirstName);
                //newItem.SubItems.Add(editForm.LastName);
                     //newItem.SubItems.Add(editForm.Age.ToString());

            personsListView.VirtualListSize = pers.Count;
                personsListView.Invalidate();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //if (personsListView.SelectedItems.Count == 0)
                //return;

            Person pEmployee = pers[personsListView.SelectedIndices[0]];

            //ListViewItem item = personsListView.SelectedItems[0];

            EditPersonForm editForm = new EditPersonForm(pEmployee);
                //editForm.FirstName = item.Text;
                    //editForm.LastName = item.SubItems[1].Text;
                         //editForm.Age = Convert.ToInt32(item.SubItems[2].Text);

            if (editForm.ShowDialog() != DialogResult.OK)
            {
                personsListView.Invalidate();
            }

            //item.Text = editForm.FirstName;
                //item.SubItems[1].Text = editForm.LastName;
                     //item.SubItems[2].Text = editForm.Age.ToString();

        }

        private void personsListView_RetrieveVirtualItem_1(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName);
                    e.Item.SubItems.Add(pers[e.ItemIndex].LastName);
                         e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder employeeList = new StringBuilder();
            foreach (Person item in pers)
            {
                employeeList.Append("Employee: \n" + item.ToString());
            }
            richTextBox1.Text = employeeList.ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (FileStream newStream = new FileStream("AllMyPersons.dat",FileMode.Create, FileAccess.Write, FileShare.None))
            {
               binFormat.Serialize(newStream, pers);
            }
            using (FileStream newStream = new FileStream("PersonsCollection.xml", FileMode.Create, FileAccess.Write,FileShare.None))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Person>));
                xmlFormat.Serialize(newStream, pers);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            try
            {
                using (FileStream newStream = new FileStream("AllMyPersons.dat", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    pers.AddRange((List<Person>)binFormat.Deserialize(newStream));
                }
            }
            catch
            { }
        }
    }
}
