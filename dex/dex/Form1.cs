using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace dex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string LerArquivo(string endereco)
        {
            string conteudo = "";

            if (File.Exists(endereco))
            {
                using (StreamReader sr = new StreamReader(endereco))
                {
                    conteudo += sr.ReadToEnd();
                }
            }

            return conteudo;
        }

        private void btnSalvar_Click_Click(object sender, EventArgs e)
        {
            string pular = "⠀";
            string telefone = txbTelefone.Text;
            string email = txbEmail.Text;
            string nome = txbInput.Text;
            
            
            if (rbTelefone.Checked)
            {
                email = "-";
            } else if (rbEmail.Checked)
            {
                telefone = "-";
            }

            string texto = nome + pular + telefone + pular + email;

            string caminho = "C:/Users/gustavo.ccorreia1/source/repos/projetojoaozika/arquivo.txt";

            string textoAntigo = LerArquivo(caminho);

            using (StreamWriter sw = new StreamWriter(caminho))
            {
                sw.WriteLine(textoAntigo + texto);
            }

            MessageBox.Show("Arquivo criado com sucesso");
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            string caminho = "C:/Users/gustavo.ccorreia1/source/repos/projetojoaozika/arquivo.txt";

            string texto = LerArquivo(caminho);

            Array lista = texto.Split('\n');

            foreach (string pessoa in lista)
            {
                string[] dados = pessoa.Split('|');

                cbxNome.Items.Add(dados[0].ToUpper());
            }
        }
    }
}
