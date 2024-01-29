using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dexyzim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero3;
            string numero4;
            string numero7;

            numero3 = textBox1.Text;
            numero4 = textBox2.Text;
            numero7 = textBox3.Text;

            textBox1.Text = numero7;
            textBox2.Text = numero4;
            textBox3.Text = numero3;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numero1;
            string numero2;
            string numero3;

            numero1 = textBox1.Text;
            numero2 = textBox2.Text;
            numero3 = textBox3.Text;

            numero1 = numero3;
            numero2 = numero2;
            numero3 = numero1;
    
        }
    }
}
