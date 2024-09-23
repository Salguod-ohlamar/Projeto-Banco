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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Frm_conta_banco banco = new Frm_conta_banco();
            banco.Show();
            Hide();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Frm_Cadastro cadastro = new Frm_Cadastro();
            cadastro.Show();
            Hide();
        }
    }
}
