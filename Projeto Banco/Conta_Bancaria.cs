using System.Windows.Forms;

namespace Projeto_Banco
{
    internal class Conta_Bancaria
    {
        public int agencia, n_conta, idade, mes_nascimento, mes;
        public double valor, saldo, invetimento ;
        public string TitularConta;

        public void sacar()
        {
            if (saldo >= valor)
            {
                saldo = saldo - valor;
                MessageBox.Show($"Você sacou 'R$: {valor}' com sucesso!", "Aviso");
            }


            

            
        }

        public void depositar()
        {

            saldo += valor;

            MessageBox.Show($"O deposito 'R$: {valor}' foi efetivado com sucesso!", "Aviso");
        }


    }
}
