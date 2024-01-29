using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odexyz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            int total = int.Parse(numero1) + int.Parse(numero2);


            lbResultado.Text = total.ToString();                               
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            int total = int.Parse(numero1) * int.Parse(numero2);


            lbResultado.Text = total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            int total = int.Parse(numero1) - int.Parse(numero2);


            lbResultado.Text = total.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            string numero1 = txbNumero1.Text;
            string numero2 = txbNumero2.Text;

            int total = int.Parse(numero1) / int.Parse(numero2);


            lbResultado.Text = total.ToString();
        }

        private void btnMaiorMenor_Click(object sender, EventArgs e)
        {
            int numero3 = int.Parse(txbNumero3.Text);

            if (numero3 < 0)
            {
                lbResultado.Text = "O numero digitado é MENOR que 0";
            }else
            {
                lbResultado.Text = "O numero digitado é MAIOR que 0";
            }


 
        }

        private void btnImparPar_Click(object sender, EventArgs e)
        {
            int numero3 = int.Parse(txbNumero3.Text);

            if (numero3 % 2 == 0) 
            {
                lbResultado.Text = "PAR";
            }
            else

            {
                lbResultado.Text = "IMPAR";
            }
            
            
            
        }
    }
}
