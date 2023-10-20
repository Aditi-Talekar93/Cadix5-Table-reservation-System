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
    public partial class Form3_about : Form
    {
        public Form3_about()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }
    }
}
