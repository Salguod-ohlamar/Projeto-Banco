using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Banco
{
    public partial class Frm_investimento : Form
    {
        public Frm_investimento()
        {
            InitializeComponent();
        }
        Conta_Bancaria conta = new Conta_Bancaria();

        int mes, contador;

        private void Txt_Valor_Investimento_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Valor_Investimento.Text =="" || conta.invetimento < 100 || conta.invetimento>conta.saldo)//condições para nao  realizar o investimento
            {
                Num_Meses.Enabled = false;//mantem o nuemro de meses desativado
            }
            else
            {
                Num_Meses.Enabled=true;
                Num_Meses.Focus();//posiciona o cursos em cima do campo.
            }
        }

        private void Frm_investimento_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_conta_banco banco = new Frm_conta_banco();//instanciando o objeto banco, para chamar a tela inicial
            banco.Show();
            Hide();//ocultando a tela de investimentos,

        }
    }
}


