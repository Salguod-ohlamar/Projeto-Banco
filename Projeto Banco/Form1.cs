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
    }
}
