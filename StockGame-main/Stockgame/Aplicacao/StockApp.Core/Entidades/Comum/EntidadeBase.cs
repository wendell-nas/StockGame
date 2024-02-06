using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Entidades.Comun
{
    public class EntidadeBase
    {
        public int Id { get; set; }

        public string Cep { get; set; }

        public string Email { get; set; }

        public string DataNascimento { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }
        public string Rua { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public bool Status { get; set; }

        public string CriadoPor { get; set;}

        public DateTime CriadoEm { get; set; }

        public string AlteradoPor { get; set; }

        public DateTime AlteradoEm { get; set; }
    }
}
