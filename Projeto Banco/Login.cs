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
            int? userId = bancoDados(Txt_Agencia.Text, Txt_Numero_Conta.Text,  Txt_Senha.Text);
            if (userId.HasValue)
            {
                MessageBox.Show("Login bem sucedido", "Aviso de Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm_conta_banco banco = new Frm_conta_banco(userId.Value);
                banco.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Login Invalido verifique as informações e tente novamente", "Login Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int? bancoDados(string agencia, string numero_conta,  string senha)
        {
            string connectionString = "Server=RYZEN-5\\SQLEXPRESS;Database=Projeto-Banco;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //var query = "SELECT ID FROM table_1 WHERE Agencia = @Agencia AND Nu_conta = @NumeroConta AND Titular = @Titular AND Senha = @Senha";
                var query = "SELECT ID FROM table_1 WHERE Agencia = @Agencia AND Nu_conta = @NumeroConta AND Senha = @Senha";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Agencia", agencia);
                cmd.Parameters.AddWithValue("@NumeroConta", numero_conta);
//                cmd.Parameters.AddWithValue("@Titular", titular);
                cmd.Parameters.AddWithValue("@Senha", senha);

                var rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    return (int)rdr["ID"];
                }
                rdr.Close();
            }
            return null;
        }






        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            Frm_Cadastro cadastro = new Frm_Cadastro();
            cadastro.Show();
            Hide();
        }

        private void Btn_MostrarOcultar_Click(object sender, EventArgs e)
        {
            // Alterna a visibilidade da senha
            if (Txt_Senha.UseSystemPasswordChar)
            {
                Txt_Senha.UseSystemPasswordChar = false;
                Btn_MostrarOcultar.Text = "Esconder";
            }
            else
            {
                Txt_Senha.UseSystemPasswordChar = true;
                Btn_MostrarOcultar.Text = "Mostrar";
            }
        }
    }


    }
