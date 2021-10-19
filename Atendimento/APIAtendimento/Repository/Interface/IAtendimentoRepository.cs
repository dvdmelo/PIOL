using APIAtendimento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAtendimento.Repository.Interface
{
    public interface IAtendimentoRepository
    {
         Task<List<Atendimento>> ListarTodos();

         Task<Atendimento> ObterPorId(int id);

         Task<Atendimento> Salvar(Atendimento model);
    }
}
