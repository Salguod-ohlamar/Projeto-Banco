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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_Banco
{
    public partial class Frm_Cadastro : Form
    {



        public Frm_Cadastro()
        {
            InitializeComponent();
        }
        Conta_Bancaria conta = new Conta_Bancaria();

        private void Txt_Titular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas letras ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (e.KeyChar == 13)
            {

                if (Txt_TitularConta.TextLength >= 3)
                {
                    Txt_Idade.Focus();
                }
                else
                {
                    MessageBox.Show("É necessário digitar ao menos 3 letras para o nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }

            }
        }

        private void Txt_idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                if (Txt_Idade.Text != "")
                {
                    conta.idade = int.Parse(Txt_Idade.Text);

                    if (conta.idade >= 18 && conta.idade <= 120)
                    {
                        Txt_mes_Nasc.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"'{conta.idade}'anos. Idade incorreta, precisa " +
                            $"ter maioridade, até 120 amos ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Txt_Idade.Clear();
                        Txt_Idade.Focus();
                    }
                }
            }
        }

        private void Txt_mes_Nasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))//condiçãao para aceitar somente numeros e teclaas e controle
            {
                e.Handled = true;//verificando se é somente número

                MessageBox.Show("Somente números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (e.KeyChar == 13)//condição para tclar o "enter"
            {
                conta.mes_nascimento = int.Parse(Txt_mes_Nasc.Text);
                if (Txt_mes_Nasc.Text != "")//condição para verificar se o campo esta vazio
                {
                    if (conta.mes_nascimento > 0 && conta.mes_nascimento < 13)
                    {
                        Txt_Senha.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"{conta.mes_nascimento}, nao é um mês valido`", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
                else// mensagem para notificação de falta de digito
                {
                    MessageBox.Show("É necessário digitar 3 digito para a idade", "Aviso", MessageBoxButtons.OK);
                }
            }
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {


            conta.email = Txt_Email.Text;
            conta.senha = Txt_Senha.Text;
            if (string.IsNullOrWhiteSpace(conta.senha))//nao deia cadastrar senha com campo bazio
            {
                MessageBox.Show("O cmapo 'Senha' esta vazio por favor digite uma senha com 8 até 32 caracteres",
                    "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Senha.Focus();

            }
            if (conta.senha.Length < 8 || conta.senha.Length > 32)// nao deixa cadastar senha menor que 8 e maior que 32
            {
                MessageBox.Show("A senha deve conter entre 8 a 32 caracteres ", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conta.validandoEmail(conta.email))//chama a a validação de email
            {
                conta.GerarAgenciNuConta();//chama o gerador de conta e agencia e numero de conta
                Txt_Agencia.Text = conta.agencia.ToString();
                Txt_Numero_Conta.Text = conta.numero_conta.ToString();

                Btn_Cadastrar.Visible = false;


                               

                if (cadastrado(Txt_Agencia.Text, Txt_Numero_Conta.Text, Txt_TitularConta.Text, Txt_Senha.Text, Txt_Email.Text, 
                    conta.idade, conta.mes_nascimento))// verifica se os campos foram rpeenchidos e insere no BD
                {
                    MessageBox.Show("Cadastro realizado com sucesso", "Cadastro", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("E-mail inválido. Por favor, insira um e-mail válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_Email.Clear();
                    Txt_Email.Focus();
                }

            }
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.Show();
            Hide();
        }
        private bool cadastrado(string agencia, string nu_conta, string titular, string senha, string email, int idade, int mes_nascimento)
        {
            string connectionString = "Server=RYZEN-5\\SQLEXPRESS;Database=Projeto-Banco;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Table_1 (titular, idade, mes_nascimento, senha, email, agencia, nu_conta) " +
                               "VALUES (@Titular, @Idade, @MesNascimento, @Senha, @Email, @Agencia, @Nu_conta)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Titular", titular);
                    command.Parameters.AddWithValue("@Idade", idade);
                    command.Parameters.AddWithValue("@MesNascimento", mes_nascimento);
                    command.Parameters.AddWithValue("@Senha", senha);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Agencia", agencia);
                    command.Parameters.AddWithValue("@Nu_conta", nu_conta);

                    command.ExecuteNonQuery();
                }
            }
            return true;
        }



    }


}
    