using Metro.Atendimento.Portal.Models;
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
        private readonly IProtocoloService protocoloService;

        public AtendimentoService(IAtendimentoRepository _atendimentoRepository, IProtocoloService _protocoloService)
        {
            atendimentoRepository = _atendimentoRepository;
            protocoloService = _protocoloService;
        }

        public Task<List<Models.Atendimento>> ListarTodos()
        {
            return atendimentoRepository.ListarTodos();
        }

        public Task<Models.Atendimento> ObterPorNumeroProtocolo(long numeroProtocolo)
        {
            return atendimentoRepository.ObterPorNumeroProtocolo(numeroProtocolo);
        }

        public Task<Models.Atendimento> Salvar(Models.Atendimento model)
        {
            model.DataSolicitacao = DateTime.Now;
            model.Status = (int)StatusAtendimento.PendenteAnalise;
            model.NumeroProtocolo = protocoloService.GerarProtocolo();
            return atendimentoRepository.Salvar(model);
        }
    }
}
