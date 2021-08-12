using caixa.design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixa
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmVendas());

            //frmLogin login = new frmLogin();
            //login.ShowDialog();

            //if (login.logado != null)
            //{
            //    Application.Run(new Principal(login.logado));
            //}
        }
    }
}
