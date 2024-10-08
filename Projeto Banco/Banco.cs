﻿using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_Banco
{
    public partial class Frm_conta_banco : Form
    {



        public Frm_conta_banco(int id)
        {
            InitializeComponent();
            CarregarDados(id);
        }

        private void CarregarDados(int id)
        {
            string connectionString = "Server=RYZEN-5\\SQLEXPRESS;Database=Projeto-Banco;Integrated Security=True;";
            string query = "SELECT agencia, nu_conta, titular, idade, mes_nascimento, email FROM table_1 WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        Txt_Agencia.Text = reader["agencia"].ToString();
                        Txt_NConta.Text = reader["nu_conta"].ToString();
                        Txt_TitularConta.Text = reader["titular"].ToString();
                       // Txt_Senha.Text = reader["senha"].ToString();
                        Txt_Mes_Nasc_Banco.Text = reader["mes_nascimento"].ToString();
                        Txt_idadeBanco.Text = reader["idade"].ToString();
                        Txt_Email_Banco.Text = reader["email"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados: " + ex.Message);
                }
            }
        }



        Conta_Bancaria conta = new Conta_Bancaria();

        int contador_saque, contador_deposito;


        private void Form1_Load(object sender, EventArgs e)
        {
            Txt_Saldo.Text = conta.saldo.ToString();
        }

        private void Btn_Saque_Click(object sender, EventArgs e)
        {
            if (Txt_Agencia.TextLength == 4 && Txt_NConta.TextLength == 5
         && Txt_TitularConta.TextLength >= 3 && !string.IsNullOrWhiteSpace(Txt_Valor.Text)
         && !string.IsNullOrWhiteSpace(Txt_idadeBanco.Text) && !string.IsNullOrWhiteSpace(Txt_Mes_Nasc_Banco.Text)
         && int.TryParse(Txt_idadeBanco.Text, out int idade) && idade >= 18 && idade <= 120
         && int.TryParse(Txt_Mes_Nasc_Banco.Text, out int mes_nascimento) && double.TryParse(Txt_Valor.Text, out double valor) && mes_nascimento > 0 && mes_nascimento <= 12)
            {
                conta.agencia = int.Parse(Txt_Agencia.Text);
                conta.numero_conta = int.Parse(Txt_NConta.Text);
                conta.TitularConta = Txt_TitularConta.Text;
                conta.valor = double.Parse(Txt_Valor.Text);
                conta.idade = int.Parse(Txt_idadeBanco.Text);
                conta.mes_nascimento = int.Parse(Txt_Mes_Nasc_Banco.Text);

                if (conta.saldo >= conta.valor)
                {
                    conta.valor = double.Parse(Txt_Valor.Text);
                    conta.sacar();
                    Txt_Saldo.Text = conta.saldo.ToString();
                    contador_saque++;//contador do saque
                    Lbl_conta_saque.Text = contador_saque.ToString();
                    Txt_Valor.Clear();

                    Txt_Agencia.Enabled = false;
                    Txt_NConta.Enabled = false;
                    Txt_TitularConta.Enabled = false;
                    Txt_Valor.Enabled = true;
                    Txt_idadeBanco.Enabled = false;
                    Txt_Mes_Nasc_Banco.Enabled = false;

                    Txt_Valor.Focus();
                }
                else
                {
                    MessageBox.Show($"Não há saldo suficiente,para esta transação", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            else
            {
                MessageBox.Show("É necessário preencher todos os campos corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Deposito_Click(object sender, EventArgs e)
        {
            if (Txt_Agencia.TextLength == 4 && Txt_NConta.TextLength == 5
         && Txt_TitularConta.TextLength >= 3 && !string.IsNullOrWhiteSpace(Txt_Valor.Text)
         && !string.IsNullOrWhiteSpace(Txt_idadeBanco.Text) && !string.IsNullOrWhiteSpace(Txt_Mes_Nasc_Banco.Text)
         && int.TryParse(Txt_idadeBanco.Text, out int idade) && idade >= 18 && idade <= 120
         && int.TryParse(Txt_Mes_Nasc_Banco.Text, out int mes_nascimento) && mes_nascimento > 0 && mes_nascimento <= 12)
            {
                conta.agencia = int.Parse(Txt_Agencia.Text);
                conta.numero_conta = int.Parse(Txt_NConta.Text);
                conta.TitularConta = Txt_TitularConta.Text;
                conta.valor = double.Parse(Txt_Valor.Text);
                conta.idade = int.Parse(Txt_idadeBanco.Text);
                conta.mes_nascimento = int.Parse(Txt_Mes_Nasc_Banco.Text);

                conta.valor = double.Parse(Txt_Valor.Text);
                conta.depositar();
                Txt_Saldo.Text = conta.saldo.ToString();
                contador_deposito++;//contador do deposito
                Lbl_Conta_Deposito.Text = contador_deposito.ToString();
                Txt_Valor.Clear();

                Txt_Agencia.Enabled = false;
                Txt_NConta.Enabled = false;
                Txt_TitularConta.Enabled = false;
                Txt_Valor.Enabled = true;
                Txt_idadeBanco.Enabled = false;
                Txt_Mes_Nasc_Banco.Enabled = false;

                Txt_Valor.Focus();
            }
            else
            {
                MessageBox.Show("É Necessário preencher todos os campo/ ou corrigir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void Txt_Agencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))//condição para aceitar somente numeros e teclas de controle
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (e.KeyChar == 13)// verificação do acinoamento da tecla enter
            {
                if (Txt_Agencia.TextLength == 4)//condição para verificar a quantidade de digito
                {
                    Txt_NConta.Focus();//posicona o cursos para o proximo foco
                }
                else
                {
                    MessageBox.Show("É Necessário preencher todos os campo/ ou corrigir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void Txt_NConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas numeros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (e.KeyChar == 13)
            {

                if (Txt_NConta.TextLength == 5)
                {
                    Txt_TitularConta.Focus();
                }
                else
                {
                    MessageBox.Show("É necessário digitar os 5 números da conta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


        }

        private void Txt_TitularConta_KeyPress(object sender, KeyPressEventArgs e)
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
                    Txt_idadeBanco.Focus();
                }
                else
                {
                    MessageBox.Show("É necessário digitar ao menos 3 letras para o nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                }

            }
        }

        private void Txt_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                if (Txt_Valor.Text != "")
                {
                    MessageBox.Show("Utilize os botôes de 'Saque' ou 'Deposito'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Txt_Valor.Focus();
                }
                else
                {
                    MessageBox.Show(" Informe um valor para continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void Txt_idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                if (Txt_idadeBanco.Text != "")
                {
                    conta.idade = int.Parse(Txt_idadeBanco.Text);

                    if (conta.idade >= 18 && conta.idade<=120)
                    {
                        Txt_Mes_Nasc_Banco.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"'{conta.idade}'anos. Idade incorreta, precisa " +
                            $"ter maioridade, até 120 amos ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Txt_idadeBanco.Clear();
                        Txt_idadeBanco.Focus();
                    }

                }

                
            }

        }

        private void Btn_investir_Click(object sender, EventArgs e)
        {
            conta.saldo =  double.Parse(Txt_Saldo.Text);

            if (conta.saldo >= 100) //valor minimo para abrir o investimento, valor minimo
            {
                Frm_investimento investimentos = new Frm_investimento();//instamciando objeto investimento, chamando a tela de investimento
                investimentos.Txt_saldo_disponivel.Text = Txt_Saldo.Text; //enviado o saldo para tela de investimentos 
                investimentos.Show(); //abre a tela de investimento           
                 Hide();//oculta a primeira tela
            }
            else
            {
                MessageBox.Show("È Necessário o saldo minimo de 'R$: 100'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_TitularConta_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_NConta_TextChanged(object sender, EventArgs e)
        {

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
                conta.mes_nascimento = int.Parse(Txt_Mes_Nasc_Banco.Text);
                if (Txt_Mes_Nasc_Banco.Text != "")//condição para verificar se o campo esta vazio
                {
                    if (conta.mes_nascimento > 0 && conta.mes_nascimento < 13)
                    {
                        Txt_Valor.Focus();
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
    }
}