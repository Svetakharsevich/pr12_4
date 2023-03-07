using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr12_4
{
    public partial class Form1 : Form
    {
        Flower flower1 = new Flower();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "") label6.Text = "Введите данные";
                else
                {
                    flower1.name = textBox1.Text;
                    flower1.shade = textBox2.Text;
                    flower1.country = textBox3.Text;
                    flower1.price = Convert.ToInt32(textBox4.Text);
                    flower1.length = Convert.ToInt32(textBox5.Text);
                    label6.Text = flower1.info;
                }
            }
            catch
            {
                label6.Text = "Введите корректные данные";
            }
           
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
