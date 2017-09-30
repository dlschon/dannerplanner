using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner
{
    public partial class Form1 : Form
    {
        BindingList<Item> homework;

        public static string FileName = "data.json";

        Dictionary<string, string> Books = new Dictionary<string, string>
        {
            { "Diff Eq", @"C:\Users\dlsch\OneDrive\Documents\Books\DifferentialEquations.pdf" },
            { "Circuits", @"C:\Users\dlsch\OneDrive\Documents\Books\Circuits.pdf" },
            { "Signals", @"C:\Users\dlsch\OneDrive\Documents\Books\Signals.pdf" }
        };

        public Form1()
        {
            InitializeComponent();

            // Initialize homework list
            LoadData();

        }

        private void LoadData()
        {
            ReadFile();

            dataGridView1.DataSource = homework;
            dataGridView1.Refresh();
        }

        private void WriteFile()
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(FileName))
            {
                file.WriteLine(JsonConvert.SerializeObject(homework));
            }

        }

        private void ReadFile()
        {
            string json;

            using (System.IO.StreamReader file = new System.IO.StreamReader(FileName))
            {
                json = file.ReadLine();
            }

            homework = JsonConvert.DeserializeObject<BindingList<Item>>(json);

            DateSort();
        }

        public void AddItem(Item item)
        {
            homework.Add(item);
            DateSort();
            
            dataGridView1.Refresh();

            WriteFile();
        }

        public void ReplaceItem(Item orig, Item newItem)
        {
            homework.Insert(homework.IndexOf(orig), newItem);
            homework.Remove(orig);
            DateSort();

            dataGridView1.Refresh();

            WriteFile();
        }

        private void DateSort()
        {
            List<Item> sortedList = homework.OrderBy(i => i.DueDate).ToList() ;
            homework = new BindingList<Item>(sortedList);
            dataGridView1.DataSource = homework;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddItemDialog dialog = new AddItemDialog(this);
            dialog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homework.RemoveAt(SelectedIndex());
            WriteFile();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = SelectedItem() == null ? "" : SelectedItem().Description;
            fileNameTextBox.Text = SelectedItem() == null ? "" : SelectedItem().Filename;
        }

        private int SelectedIndex()
        {
            try
                { return dataGridView1.SelectedRows[0].Index; }
            catch
                { return 0; }
            }

        private Item SelectedItem()
        {
            try
                { return homework[SelectedIndex()]; }
            catch
                { return null; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var file = SelectedItem().Filename;

            if (File.Exists(file))
                System.Diagnostics.Process.Start(file);
            else
                MessageBox.Show("File not found");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddItemDialog dialog = new AddItemDialog(this, SelectedItem());
            dialog.Show();
        }

        private void diffEqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Books["Diff Eq"]);
        }

        private void circuitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Books["Circuits"]);
        }

        private void signalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Books["Signals"]);
        }
    }
}
