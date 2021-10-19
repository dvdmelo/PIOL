using APIAtendimento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAtendimento.Services.Interface
{
    public interface IAtendimentoService
    {
        Task<List<Atendimento>> ListarTodos();

        Task<Atendimento> ObterPorId(int id);

        Task<Atendimento> Salvar(Atendimento model);
    }
}
