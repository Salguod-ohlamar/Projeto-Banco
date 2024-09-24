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
                Frm_conta_banco banco = new Frm_conta_banco(Txt_Agencia.Text, Txt_Numero_Conta.Text, Txt_Titular.Text, Txt_Senha.Text);
                banco.Show();
                Hide();

            }


        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Frm_Cadastro cadastro = new Frm_Cadastro();
            cadastro.Show();
            Hide();
        }
        private bool bancoDados(string agencia, string numero_conta, string titular, string senha)
        {
            string connectionString = "Server=RYZEN-5\\SQLEXPRESS;Database=Projeto-Banco;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "select * from table_1";
                SqlCommand cmd = new SqlCommand(query, connection);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr["Agencia"].ToString() == agencia && rdr["Nu_conta"].ToString() == numero_conta
                        && rdr["Titular"].ToString() == titular && rdr["Senha"].ToString() == senha)
                    {
                        return true;
                    }
                }
                rdr.Close();
            }
            return false;
        }
    }
}