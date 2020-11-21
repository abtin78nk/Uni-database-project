using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Uni
{
    public partial class Managerform : Form
    {
        public Managerform()
        {
            InitializeComponent();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            new addstudform().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new addprofform().ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new crsaddform().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new clgaddform().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new studreportform().ShowDialog();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new secform().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new studreportform().ShowDialog();
        }
    }
}
