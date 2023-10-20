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
    public partial class Form4_contact : Form
    {
        public Form4_contact()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form7_rev obj = new Form7_rev();
            obj.Show();
        }
    }
}
