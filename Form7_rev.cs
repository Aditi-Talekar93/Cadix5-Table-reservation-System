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
    public partial class Form7_rev : Form
    {
        string name;
        int price;
        int t;
        public Form7_rev()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            ;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                name = "Fried Rice";
                int qty = int.Parse(numericUpDown1.Text);
                price = 20;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox2.Checked)
            {
                name = "Fried Chicken";
                int qty = int.Parse(numericUpDown2.Text);
                price = 30;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox3.Checked)
            {
                name = "sushi";
                int qty = int.Parse(numericUpDown3.Text);
                price = 30;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox4.Checked)
            {
                name = "Pizza";
                int qty = int.Parse(numericUpDown4.Text);
                price = 40;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox5.Checked)
            {
                name = "Spaghetti Carbonara";
                int qty = int.Parse(numericUpDown5.Text);
                price = 40;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox6.Checked)
            {
                name = "Chicken Burger";
                int qty = int.Parse(numericUpDown6.Text);
                price = 35;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox7.Checked)
            {
                name = "Tacos";
                int qty = int.Parse(numericUpDown7.Text);
                price = 32;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox8.Checked)
            {
                name = "Pancake";
                int qty = int.Parse(numericUpDown8.Text);
                price = 20;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox9.Checked)
            {
                name = "Salad";
                int qty = int.Parse(numericUpDown9.Text);
                price = 10;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox10.Checked)
            {
                name = "Pad Thai";
                int qty = int.Parse(numericUpDown14.Text);
                price = 18;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }

            if (checkBox11.Checked)
            {
                name = "Sashimi";
                int qty = int.Parse(numericUpDown15.Text);
                price = 18;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }

            if (checkBox12.Checked)
            {
                name = "Lobster Bisque";
                int qty = int.Parse(numericUpDown16.Text);
                price = 28;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox13.Checked)
            {
                name = "Smoothie Bowl";
                int qty = int.Parse(numericUpDown17.Text);
                price = 10;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox14.Checked)
            {
                name = "IceCream Sundae";
                int qty = int.Parse(numericUpDown18.Text);
                price = 10;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox15.Checked)
            {
                name = "Ramen";
                int qty = int.Parse(numericUpDown13.Text);
                price = 18;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox16.Checked)
            {
                name = "Chicken Satay";
                int qty = int.Parse(numericUpDown12.Text);
                price = 18;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox17.Checked)
            {
                name = "Fish n Chips";
                int qty = int.Parse(numericUpDown11.Text);
                price = 15;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            if (checkBox18.Checked)
            {
                name = "Dim Sum";
                int qty = int.Parse(numericUpDown10.Text);
                price = 10;
                t = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, t);
            }
            int sum = 0;

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }

            textBox1.Text = sum.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5_res obj = new Form5_res();
            obj.Show();
        }
    }
    
}
