using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metro.Atendimento.Portal.Services.Interface
{
    public interface IAtendimentoService
    {
        Task<List<Models.Atendimento>> ListarTodos();

        Task<Models.Atendimento> ObterPorNumeroProtocolo(long numeroProtocolo);

        Task<Models.Atendimento> Salvar(Models.Atendimento model);
    }
}
