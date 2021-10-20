using Metro.Atendimento.Portal.Repository.Interface;
using Metro.Atendimento.Portal.Services.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metro.Atendimento.Portal.Services
{
    public class AtendimentoService : IAtendimentoService
    {
        private readonly IAtendimentoRepository atendimentoRepository;

        public AtendimentoService(IAtendimentoRepository _atendimentoRepository)
        {
            atendimentoRepository = _atendimentoRepository;
        }

        public Task<List<Models.Atendimento>> ListarTodos()
        {
            return atendimentoRepository.ListarTodos();
        }

        public Task<Models.Atendimento> ObterPorId(int id)
        {
            return atendimentoRepository.ObterPorId(id);
        }

        public Task<Models.Atendimento> Salvar(Models.Atendimento model)
        {
            model.DataSolicitacao = DateTime.Now;
            return atendimentoRepository.Salvar(model);
        }
    }
}
