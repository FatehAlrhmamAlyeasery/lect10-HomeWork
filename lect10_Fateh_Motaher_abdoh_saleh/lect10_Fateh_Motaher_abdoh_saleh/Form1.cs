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
namespace lect10_Fateh_Motaher_abdoh_saleh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("*.png");
            comboBox1.Items.Add("*.jpg");
            comboBox1.Items.Add("*.txt");
            comboBox1.SelectedIndex = 1;
        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Path = dirListBox1.Path;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Parent.Text =   comboBox1.Text.Trim();
        }

        private void fileListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = fileListBox1.Path + "\\" + fileListBox1.FileName;
            label5.Text = Path.GetFileName(label4.Text);
            label6.Text = Path.GetExtension(label4.Text);
            if (label6.Text.ToLower() == ".png" || label4.Text.ToLower() == ".jpg")
            {
                pictureBox1.Image = Image.FromFile(label4.Text);
                richTextBox1.Text = null;
            }
            else if (label6.Text.ToLower() == ".txt")

            { richTextBox1.Text = File.ReadAllText(label4.Text);
                pictureBox1.Image = null;
            }
        }
    }
}
