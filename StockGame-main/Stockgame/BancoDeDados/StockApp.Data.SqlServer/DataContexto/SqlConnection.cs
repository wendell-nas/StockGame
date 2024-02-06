using System;
using System.Collections.Generic;


using System.Configuration;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Data.SqlServer.DataContexto
{
    internal static class SqlServerConnection
    {
        /// <summary>
        /// Propriedade <c>Conexao</c> retorna a string que foi definida no arquivo App.config.
        /// </summary>

        internal static string Conexao => @"Data Source=.\SQLEXPRESS;Initial Catalog=StockGame;User ID=sa;Password=sql2022; Trusted_Connection = False; TrustServerCertificate = True;";

    }
}
