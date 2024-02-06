using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Ultilidade
{
    public class GerarSenha
    {
        public string GerarSenhaAleatoria()
        {
            const string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder senha = new StringBuilder();

            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                int indice = random.Next(caracteresPermitidos.Length);
                senha.Append(caracteresPermitidos[indice]);
            }

            return senha.ToString();
        }
    }

}
