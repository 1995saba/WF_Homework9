using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework9
{
    public partial class MainForm : Form
    {
        public EditForm editForm;
        public MainForm()
        {
            InitializeComponent();
            editForm = new EditForm(this);
        }
        private void DownloadFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = editForm.Path = openFileDialog.FileName;
            string fileText = System.IO.File.ReadAllText(filename);

            textBox.Text = fileText;

            editForm.InitializeText(fileText);
            editButton.Enabled = true;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                editForm.Show();
            }
            catch
            {
                EditForm editForm = new EditForm(this);
                editForm.Show();
            }
        }
    }
}
