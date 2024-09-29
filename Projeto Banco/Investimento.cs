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

        private void Txt_Valor_Investimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // validacao do campo para que entre somente números
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Somente números !!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (e.KeyChar == 13)
            {
                if (Txt_Valor_Investimento.Text != "")// verificando se o valor de investimento esta vazio
                {
                    conta.invetimento = double.Parse(Txt_Valor_Investimento.Text);//recebendo/armazenando o valor digitdo 
                    conta.saldo = double.Parse(Txt_saldo_disponivel.Text); //a variavel da classe recebe saldo disponnivel
                    
                    if(conta.invetimento <100  || conta.invetimento > conta.saldo)
                    {
                        MessageBox.Show("O valor minimo de investimento é de R$100,00", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Txt_Valor_Investimento.Clear();
                        Txt_Valor_Investimento.Focus();
                    }
                    else // se o valor de investimento for no minimo 100e dentro do saldo 
                    {
                        conta.saldo-= conta.invetimento;// calculo do investimento 
                        Txt_saldo_disponivel.Text= conta.saldo.ToString();//atualizando saldo após inestimento
                        Txt_Valor_Investimento.Enabled =false;//desativando o preenchimento do valor de invetimento
                        Num_Meses.Enabled =true;//ativando os meses
                        Num_Meses.Focus();//posicionando o cursor na seleção de meses
                    }

                }
                else
                {
                    MessageBox.Show("Digite o valor do investimento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void Num_Meses_ValueChanged(object sender, EventArgs e)
        {
            mes = (int)Num_Meses.Value;// a var recebe a qtd de meses.
            conta.invetimento = double.Parse(Txt_Valor_Investimento.Text);// a variavelda classe recebeu o valor do investimento 
            List_Meses.Items.Clear();//limpar os meses da lista
            List_Rendimento.Items.Clear();// limpar os rendimentos da lista

            for (contador = 1; contador <= mes; contador++)
            {
                if (contador == 1)// se o contador for 1
                {
                    List_Meses.Items.Add(contador);//mostrar a contagem dentro da lista
                    List_Rendimento.Items.Add(conta.invetimento);//mostara o valor do investimento dentro da lista
                }
                else
                {
                    List_Meses.Items.Add(contador); //contiua a contagem da lista
                    List_Rendimento.Items.Add(conta.invetimento += conta.invetimento * 1/ 100);//calculo de rendimento 
                }
            }
; // estrutura de repetição com o laço FOR
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            
            //Frm_conta_banco banco = new Frm_conta_banco();//instanciando o objeto banco, para chamar a tela inicial
           // banco.Show();
            //conta.saldo -= conta.invetimento;//calculo do invetsimento
            //banco.Txt_Saldo.Text = Txt_saldo_disponivel.Text;//saldo da tela investo para o saldo da tela principal
            Hide();//ocultando a tela de investimentos,

        }
    }
}


