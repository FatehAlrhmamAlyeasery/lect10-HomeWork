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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void إدارةالملفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
     
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        addstudent add;
        private void اضافةطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {if(add == null || add.IsDisposed)
            {
                add = new addstudent();
                add.Show();

            }
            else
            {
                add.Show();
                add.Focus();
            }
            
        }
        showstudent sh;
        private void عرضالطلابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sh == null || sh.IsDisposed)
            {
                sh = new showstudent();
                sh.Show();
            }
            else
            {
                sh.Show();
                sh.Focus();
            }

        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = Application.OpenForms.Count;
            if (count > 1)
            {
                Application.OpenForms[count - 1].Close();
            }
        }

        private void اغلاقالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = Application.OpenForms.Count;
            if (count > 1)
            {
                for (int i = count - 1; i >= 1; i++)
                    Application.OpenForms[i].Close();
            }
        }
    }
}
