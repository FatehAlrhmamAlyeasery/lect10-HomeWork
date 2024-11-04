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
    public partial class showstudent : Form
    {
        public showstudent()
        {
            InitializeComponent();
        }

        private void showstudent_Load(object sender, EventArgs e)
        {
            loadstudentdata();
            listBox1.SelectedIndexChanged += finedselectedindexlistbox;
            listBox2.SelectedIndexChanged += finedselectedindexlistbox;
            listBox3.SelectedIndexChanged += finedselectedindexlistbox;
            ;
        }
        void loadstudentdata()
        {
            for (int i = 0; i < addstudent.count; i++)
            {
                listBox1.Items.Add(addstudent.s[i].getnumber().ToString());
                listBox2.Items.Add(addstudent.s[i].getname());
                listBox3.Items.Add(addstudent.s[i].getbirthdate());
                pictureBox1.Image = Image.FromFile(addstudent.s[i].getimagepath());
            }
        }
        public static int index = -1;
        private void finedselectedindexlistbox(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
            {
                index = listBox1.SelectedIndex = listBox2.SelectedIndex = listBox3.SelectedIndex = ((ListBox)sender).SelectedIndex;
                pictureBox1.Image = Image.FromFile(addstudent.s[index].getimagepath());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
                listBox3.Items.Remove(listBox3.SelectedItem);
                for (int i = index; i < addstudent.count; i++)
                    addstudent.s[i] = addstudent.s[i + 1];
                addstudent.count--;
                if (addstudent.count >= 1)
                {
                    pictureBox1.Image = Image.FromFile(addstudent.s[0].getimagepath());
                    listBox1.SelectedIndex = listBox2.SelectedIndex = listBox3.SelectedIndex = 0;
                }
                else
                    pictureBox1.Image = null;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            loadstudentdata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                showstudent f = new showstudent();
                f.ShowDialog();
                listBox1.Items[index] = addstudent.s[index].getnumber();
                listBox2.Items[index] = addstudent.s[index].getname();
                listBox3.Items[index] = addstudent.s[index].getbirthdate();
                pictureBox1.Image = Image.FromFile(addstudent.s[index].getimagepath());
            }
        }
    }
}
