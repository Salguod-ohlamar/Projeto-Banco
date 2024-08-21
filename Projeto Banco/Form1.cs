using System;
using System.Windows.Forms;

namespace Projeto_Banco
{
    public partial class Frm_conta_banco : Form
    {
        public Frm_conta_banco()
        {
            InitializeComponent();
        }

        Conta_Bancaria conta = new Conta_Bancaria();


        private void Form1_Load(object sender, EventArgs e)
        {
            Txt_Saldo_Disponivel.Text = conta.saldo.ToString();
        }

        private void Btn_Saque_Click(object sender, EventArgs e)
        {
            if (Txt_Valor.Text != "")
            {
                conta.valor = double.Parse(Txt_Valor.Text);
                conta.sacar();
                Txt_Saldo_Disponivel.Text = conta.saldo.ToString();
            }
            else
            {
                MessageBox.Show("Você precisa informar uma valor para sacar", "Aviso");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conta.valor = double.Parse(Txt_Valor.Text);
            conta.depositar();
            Txt_Saldo_Disponivel.Text = conta.saldo.ToString();
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
                    MessageBox.Show("è necessário digitar os 4 digitos de agência", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                
                if (Txt_TitularConta.TextLength >=3)
                {
                    Txt_Valor.Focus();
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
                e.Handled= true;
            }
            if (e.KeyChar == 13)
            {
                if (Txt_Valor.Text != "")
                {
                    MessageBox.Show("Utilize os botôes de 'Saque' ou 'Deposito'", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show(" Informe um valor para continuar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }
    }
}
