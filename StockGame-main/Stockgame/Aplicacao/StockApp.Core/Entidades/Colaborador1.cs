
using StockApp.Core.Entidades.Comun;

namespace StockApp.Core.Entidades
{
    public class Colaborador1 : EntidadeBase
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public int TelefoneId { get; set; }
        public int CargoId { get; set; }
        public int EnderecoId { get; set; }
        

    }
}
