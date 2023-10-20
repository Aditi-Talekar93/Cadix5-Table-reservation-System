using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Policy;


namespace codathon_draft
{
    public partial class Form5_res : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader dr;

        public Form5_res()
        {
            InitializeComponent();
        }
        String s1, s2, s3, s5,s6;
        decimal s4;

        private void label13_Click(object sender, EventArgs e)
        {
            Form6_menu obj = new Form6_menu();
            obj.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            numericUpDown1.Value= 0;
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
            dateTimePicker1.ResetText();
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=ADITI-LAPTOP-U4;Initial Catalog=table_res;Integrated Security=True";
            conn = new SqlConnection(connString);
            conn.Open();

            cmd = new SqlCommand("insert into Table_res values(@First_Name, @Last_Name , @No_of_Persons,@Date,@Time,@Tableno)", conn);
            cmd.Parameters.AddWithValue("First_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("Last_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("No_of_Persons", numericUpDown1.Text);
            cmd.Parameters.AddWithValue("Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("Time", comboBox1.Text);
            cmd.Parameters.AddWithValue("Tableno", comboBox3.Text);
            cmd.ExecuteNonQuery();
            
            
            MessageBox.Show(" Dear " + textBox1.Text + " You've successfully booked the "+comboBox3.Text+ " Thankyou visit again.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            s1 = textBox1.Text;
            s2 = textBox2.Text;
            s3 = comboBox3.Text;
            s4 = numericUpDown1.Value;
            s5 = dateTimePicker1.Text;
            s6 = comboBox1.Text;
            
        }

        private void Form5_res_Load(object sender, EventArgs e)
        {
           
        }
    }
    
}
