using System;
using System.Windows.Forms;

namespace Projeto_Banco
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Frm_conta_banco());
            Application.Run(new Frm_Login());
        }
    }
}
