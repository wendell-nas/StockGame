using StockApp.Core.Entidades.Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Entidades
{
    public class Colaborador : EntidadeBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Departamento { get; set; }
        public string Senha { get; set; }

        public string DataNascimento { get; set; }
        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Numero { get; set; }
        public string Logadouro { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }

        public bool Status { get; set; }

        public List<Colaborador> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
