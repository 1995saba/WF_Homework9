using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Homework9
{
    public partial class EditForm : Form
    {
        public string Path { get; set; }
        public EditForm(MainForm mainForm)
        {
            InitializeComponent();
        }
        public void InitializeText(string text)
        {
            textBox.Text = text;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using(StreamWriter stream=new StreamWriter(Path))
                {
                    stream.WriteLine(textBox.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Файл успешно сохранен");

            Close();
        }
    }
}
