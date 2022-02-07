using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_02_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") 
            {
                MessageBox.Show("Nem lehet üres a doboz :-)");
            }
            else
            {
                int tryparse = 0;
                bool isNumber = int.TryParse(textBox1.Text, out tryparse);
                if (isNumber == true)
                {
                    label2.Text = $"Eredmény: {DateTime.Now.Year - int.Parse(textBox1.Text)} éves vagy.";
                }
                else
                {
                    MessageBox.Show("Hiba. Számot kellene beírni.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
