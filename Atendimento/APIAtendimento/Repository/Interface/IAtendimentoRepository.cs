using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metro.Atendimento.Portal.Repository.Interface
{
    public interface IAtendimentoRepository
    {
         Task<List<Models.Atendimento>> ListarTodos();

         Task<Models.Atendimento> ObterPorId(int id);

         Task<Models.Atendimento> Salvar(Models.Atendimento model);
    }
}
