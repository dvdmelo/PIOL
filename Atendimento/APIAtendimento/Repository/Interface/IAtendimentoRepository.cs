using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metro.Atendimento.Portal.Repository.Interface
{
    public interface IAtendimentoRepository
    {
         Task<List<Models.Atendimento>> ListarTodos();

         Task<Models.Atendimento> ObterPorNumeroProtocolo(long numeroProtocolo);

         Task<Models.Atendimento> Salvar(Models.Atendimento model);
    }
}
