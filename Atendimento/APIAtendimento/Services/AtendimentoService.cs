using APIAtendimento.Models;
using APIAtendimento.Repository.Interface;
using APIAtendimento.Services.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIAtendimento.Services
{
    public class AtendimentoService : IAtendimentoService
    {
        private readonly IAtendimentoRepository atendimentoRepository;

        public AtendimentoService(IAtendimentoRepository _atendimentoRepository)
        {
            atendimentoRepository = _atendimentoRepository;
        }

        public Task<List<Atendimento>> ListarTodos()
        {
            return atendimentoRepository.ListarTodos();
        }

        public Task<Atendimento> ObterPorId(int id)
        {
            return atendimentoRepository.ObterPorId(id);
        }

        public Task<Atendimento> Salvar(Atendimento model)
        {
            return atendimentoRepository.Salvar(model);
        }
    }
}
