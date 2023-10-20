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
    public partial class Form2_gallery : Form
    {
        public Form2_gallery()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form6_menu obj= new Form6_menu();
            obj.Show();
        }
    }
}
