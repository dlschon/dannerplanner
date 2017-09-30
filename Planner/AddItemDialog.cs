using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner
{
    public partial class AddItemDialog : Form
    {
        Form1 MainForm;
        private Item item = null;

        public AddItemDialog(Form1 mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;
        }

        public AddItemDialog(Form1 mainForm, Item item) : this(mainForm)
        {
            this.item = item;

            TextClass.Text = item.Class;
            TextAssignment.Text = item.Assignment;
            dateTimePicker1.Value = item.DueDate;
            TextDescription.Text = item.Description;
            TextFile.Text = item.Filename;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var newItem = new Item(TextClass.Text, TextAssignment.Text, TextDescription.Text, dateTimePicker1.Value.Date, TextFile.Text);

            if (item == null)
                MainForm.AddItem(newItem);
            else
                MainForm.ReplaceItem(item, newItem);

            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TextFile.Text = dialog.FileName;
            }
        }
    }
}
