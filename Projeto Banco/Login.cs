using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Banco
{
    public partial class Frm_Login : Form

    {
        public Frm_Login()
        {

            InitializeComponent();
        }

        
        private void Btn_Login_Click(object sender, EventArgs e)
        {
                if (bancoDados(Txt_Agencia.Text, Txt_Numero_Conta.Text, Txt_Titular.Text, Txt_Senha.Text))
                {
                    MessageBox.Show("Login bem sucedido", "Aviso de Login0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_conta_banco banco = new Frm_conta_banco(Txt_Agencia.Text, Txt_Numero_Conta.Text, Txt_Titular.Text,
                      Txt_Senha.Text);
                    banco.Show();
                    Hide();

                }
                else
                {
                    MessageBox.Show("Login Invalido verifique as informações e tente novamente ", "Login Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
        }
        
        
        private bool bancoDados(string agencia, string numero_conta, string titular, string senha)//função para conectar ao banco de dados
        {
            string connectionString = "Server=RYZEN-5\\SQLEXPRESS;Database=Projeto-Banco;Integrated Security=True;";// cria uma variavel par aconectar ao Banco
            using (SqlConnection connection = new SqlConnection(connectionString))// criar uma instancoa de conexao
            {
                connection.Open();
                var query = "select * from table_1";//faz uma seleção no banco de tudo o que tem dentro
                SqlCommand cmd = new SqlCommand(query, connection); //realiza a pesquisa criando uma instancia e executando comandos 
                var rdr = cmd.ExecuteReader();// poe o resultado em uma nova variavel para ver o resultado
                while (rdr.Read()) // executa a leitura dos campos
                {
                    if (rdr["Agencia"].ToString() == agencia && rdr["Nu_conta"].ToString() == numero_conta
                        && rdr["Titular"].ToString() == titular && rdr["Senha"].ToString() == senha)
                    {
                        return true;// interrompe a instancia aberta
                    }
                }
                rdr.Close();
            }
            return false;
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            Frm_Cadastro cadastro = new Frm_Cadastro();
            cadastro.Show();
            Hide();
        }
    }


    }
