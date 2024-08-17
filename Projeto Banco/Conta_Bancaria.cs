using System.Windows.Forms;

namespace Projeto_Banco
{
    internal class Conta_Bancaria
    {
        public int agencia, n_conta;
        public double valor, saldo = 100;


        public void sacar()
        {
            if (saldo >= valor)
            {
                saldo = saldo - valor;
            }


            else
            {
                DialogResult resultado = MessageBox.Show($"Saldo insuficiente! apenas {saldo}," +
                    $" poderá ser retirado, deseja continuar?", "Aviso", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    saldo = 0;

                }
                else
                {
                    MessageBox.Show("Operação Cancelada. O saldo permanece inalterado", "Aviso");
                }

            }
        }

        public void depositar()
        {

            saldo += valor;

            MessageBox.Show($"O deposito {valor} foi efetivado com sucesso!", "Aviso");
        }


    }
}
