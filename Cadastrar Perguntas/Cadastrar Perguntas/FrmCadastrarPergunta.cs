using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cadastrar_Perguntas
{
    public partial class FrmCadastrarPergunta : Form
    {
        public FrmCadastrarPergunta()
        {
            InitializeComponent();
        }

        string conexaoString =
            "server=localhost;user=root;password=;database=show_do_milhao;";

        public long CadastrarAlternativas(string alternativa, long perguntaID)
        {
            long idAlternativa = 0;
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();

                string insert_Questoes = "INSERT INTO Questoes (Respostas_Corretas, id_perguntas) VALUE (@respostas, @id_perguntas)";

                using (MySqlCommand comando = new MySqlCommand(insert_Questoes, conexao))
                {
                    comando.Parameters.AddWithValue("@respostas", alternativa);
                    comando.Parameters.AddWithValue("@id_perguntas", perguntaID);

                    comando.ExecuteNonQuery();
                    idAlternativa = comando.LastInsertedId;

                }


            }

            return idAlternativa;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string pergunta = "";
            string alternativaA = "", alternativaB,
                alternativaC = "", alternativaD = "";
            long ultimoID = 0;
            long idAlternativaA = 0, idAlternativaB = 0, idAlternativaC = 0, idAlternativaD = 0;


            pergunta = rtxPergunta.Text;

            alternativaA = txbAlternativaA.Text;
            alternativaB = txbAlternativaB.Text;
            alternativaC = txbAlternativaC.Text;
            alternativaD = txbAlternativaD.Text;

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();
                string scripInsert = "INSERT INTO Questoes (nome_da_pergunta) VALUE (@questao)";

                using (MySqlCommand comando = new MySqlCommand(scripInsert, conexao))
                {
                    comando.Parameters.AddWithValue("@questao", pergunta);

                    comando.ExecuteNonQuery();

                    ultimoID = comando.LastInsertedId;


                }
            }
            idAlternativaA = CadastrarAlternativas(alternativaA, ultimoID);
            idAlternativaB = CadastrarAlternativas(alternativaB, ultimoID);
            idAlternativaC = CadastrarAlternativas(alternativaC, ultimoID);
            idAlternativaD = CadastrarAlternativas(alternativaD, ultimoID);

            if (rbAlternativaCorretaA.Checked)
            {
                CadastrarResposta(ultimoID, idAlternativaA);
            } else if (rbAlternativaCorretaB.Checked)
            {
                CadastrarResposta(ultimoID, idAlternativaB);
            } else if (rbAlternativaCorretaC.Checked)
            {
                CadastrarResposta(ultimoID, idAlternativaC);
            } else if (rbAlternativaCorretaD.Checked)
            {
                CadastrarResposta(ultimoID, idAlternativaD);
            }

            MessageBox.Show("Pergunta Cadastrada com Sucesso!!!" + ultimoID.ToString());
        }



        public void CadastrarResposta(long idPergunta, long idAlternativa)
        {
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();
                string scriptInsertResposta = "INSERT INTO Respostas_Corretas (id_perguntas) VALUE (@id_alternativa, @id_pergunta)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsertResposta, conexao))
                {
                    comando.Parameters.AddWithValue("@id_alternativa", idPergunta);
                    comando.Parameters.AddWithValue("@id_pergunta", idAlternativa);

                    comando.ExecuteNonQuery();
                }
            }
        }

        private void FrmCadastrarPergunta_Load(object sender, EventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            Form consultarPergunta = new FrmConsultarPergunta();

            consultarPergunta.Show();
        }
    }
}
