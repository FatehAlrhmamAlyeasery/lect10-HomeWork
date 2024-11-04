using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect10_Fateh_Motaher_abdoh_saleh
{
    public partial class addstudent : Form
    {
        public static student[] s = new student[100];
        public static int count = 0;
        public addstudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool ischoseimage = false;
        private void addstudent_Load(object sender, EventArgs e)
        {
     
        }
        private void linkedlabel1_linkedlabel(object sender, EventArgs e)
        {
          
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                ischoseimage = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (count < 100)
            {
                if (ischoseimage)
                {
                    s[count] = new student();
                    s[count].setnumber(Convert.ToInt32(numericUpDown1.Value));
                    s[count].setname(textBox1.Text.Trim());
                    s[count].setbirtdate(dateTimePicker1.Text);
                    s[count].setimagpath(openFileDialog1.FileName);
                    count++;
                    ischoseimage = false;
                    pictureBox1.Image = null;
                    numericUpDown1.Value = 0;
                    textBox1.Text = "";
                    MessageBox.Show(" تم اضافة طالب بنجاح", "نجاح");

                }
                else
                    MessageBox.Show("الرجاء اختيار صورة طالب");
            }
           else  MessageBox.Show("لقد تجاوزت الحد الادنى المسموح به");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // يتحقق من أن الحرف المدخل هو حرف أبجدي أو مفتاح المسافة
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // يمنع الإدخال
            }
            else
            {
                e.Handled = false; // يسمح بالإدخال
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {
            linkedlabel1_linkedlabel(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
