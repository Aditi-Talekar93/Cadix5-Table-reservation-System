using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codathon_draft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       // private void label1_Click(object sender, EventArgs e)
       // {

       // }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form2_gallery obj = new Form2_gallery();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3_about obj1 = new Form3_about();
            obj1.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form4_contact obj2 = new Form4_contact();
            obj2.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form5_res obj3 = new Form5_res();
            obj3.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form6_menu obj4 = new Form6_menu();
            obj4.Show();
        }
    }
}
