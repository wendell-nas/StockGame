using StockApp.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Repository
{
    public interface IColaboradorRepository
    {
        bool Incluir(Colaborador1 colaborador);
        bool Atualizar(Colaborador1 colaborador);
        bool Deletar(int id);

        List<Colaborador1> ObterTodos();

        List<Colaborador1> ObterPorId(int id);

        List<Colaborador1> ObterDepartamento();

        List<Colaborador1> FiltrarDepartamento(string departamento);

        List<Colaborador1> ObterTodosPorStatus(int status);
        
    }
}
