
using StockApp.Core.Entidades.Comun;
using StockApp.Desktop.Forms.Categorias;
using StockApp.Desktop.Forms.Clientes;
using StockApp.Desktop.Forms.Colaborador;
using StockApp.Desktop.Forms.Produtos;
using StockApp.Desktop.Forms.TelaMenu;
using StockApp.Desktop.Forms.Usuario;


namespace StockApp.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new FrmMenu());

        }
    }
}