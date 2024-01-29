using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gustavinn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            
        }

        public void escolhaOperador(int numero, string operadorEscolhido)
        {
            lbTemp.Text = numero.ToString();
            lbOperador.Text = operadorEscolhido;
            txbNumero1.Text = "";
        }
        public int resultadoSoma(int num1, int num2)
        {
            int resultado;

            resultado = num1 + num2;

            return resultado;
        }
        public int calculos(int num1, int num2, string operador)
        {
            int resultado = 0;

            if (operador == "+")
            {
                resultado = num1 + num2;
            } else if (operador == "-")
            {
                resultado = num1 - num2;
            } else if (operador == "*")
            {
                resultado = num1 * num2;
            } else if (operador == "/")
            {
                resultado = num1 / num2;
            }

            return resultado;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbNumero1.Text);
            int numero2 = 0;

            int total;

            //total = calculos(numero1, numero2, "/");

            //lbResultado.Text = total.ToString();

            escolhaOperador(25, "/");
        }
        private void btnMais_Click(object sender, EventArgs e)
        {
            if (txbNumero1.Text != "" && txbNumero1.Text != "Error")
            {
                int numero1 = int.Parse(txbNumero1.Text);

                //int numero2 = int.Parse( txbNumero2.Text );
                int numero2 = 0;
                int total;

                Button botao = (Button)sender;
                string operadorSelecionado = botao.Text;

                //total = resultadoSoma(numero1, numero2);

                //total = calculos(numero1, numero2, operadorSelecionado);
                //lbResultado.Text = total.ToString();

                escolhaOperador(numero1, operadorSelecionado);



            }
            else
            {
                txbNumero1.Text = "Error";
            }

                

        }
        private void btnVezes_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbNumero1.Text);
            int numero2 = 0;

            int total;

            //total = calculos(numero1, numero2, "*");

            //lbResultado.Text = total.ToString();

            escolhaOperador(25, "x");
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbNumero1.Text);
            int numero2 = 0;

            int total;

            //total = calculos(numero1, numero2, "-");

            //lbResultado.Text = total.ToString();

            escolhaOperador(25, "-");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button valorBotao = (Button)sender;

            //MessageBox.Show(valorBotao.Text);

            txbNumero1.Text += valorBotao.Text;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbResultado.Text = "";
            txbNumero1.Text = "";
        }

        private void lbOperador_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

            int primeiro_numero = int.Parse(lbTemp.Text);
            int segundo_numero = int.Parse(txbNumero1.Text);
            string operador = lbOperador.Text;

            int total = calculos(primeiro_numero, segundo_numero, operador);

            lbResultado.Text = total.ToString();

            //MessageBox.Show(primeiro_numero + " | " + segundo_numero + " | " + operador);
        }
    }
}
