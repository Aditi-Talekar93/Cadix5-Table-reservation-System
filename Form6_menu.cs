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
    public partial class Form6_menu : Form
    {
        public Form6_menu()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form7_rev obj =new Form7_rev();
            obj.Show();
        }
    }
}
