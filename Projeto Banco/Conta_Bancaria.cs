using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Projeto_Banco
{


    internal class Conta_Bancaria
    {
        public int agencia, numero_conta, idade, mes_nascimento, mes;
        public double valor, saldo, invetimento;
        public string TitularConta, email, senha;


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

        public void GerarAgenciNuConta()
        {
            Random random = new Random();
            agencia = random.Next(1000, 10000);// gera um numero de 4 digitos
            numero_conta = random.Next(10000, 100000);//gera um numero de 5 digitos

            MessageBox.Show("Guarde o numero da sua Agencia e conta para efetuar login","Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        public bool validandoEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}

