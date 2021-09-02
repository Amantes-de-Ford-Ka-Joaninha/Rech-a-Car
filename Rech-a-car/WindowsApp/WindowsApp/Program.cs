using Dominio.PessoaModule;
using System;
using System.Windows.Forms;
using WindowsApp.AluguelModule;

namespace WindowsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new TelaPrincipal(new Funcionario("Alexandre Rech", "99999999999", "Rua do Flamengo", "999999", Properties.Resources.rech, "admin", "admin123")).Show();

            Application.Run();
        }
    }
}
