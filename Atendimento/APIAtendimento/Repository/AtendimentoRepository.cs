using Metro.Atendimento.Portal.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metro.Atendimento.Portal.Repository
{
    public class AtendimentoRepository : IAtendimentoRepository
    {
        private readonly AppDbContext context;

        public  AtendimentoRepository(AppDbContext _context)
        {
            context = _context;
        }

        public Task<List<Models.Atendimento>> ListarTodos()
        {
            var atendimentos = context.Atendimentos.ToListAsync();

            return atendimentos;
        }

        public async Task<Models.Atendimento> ObterPorId(int id)
        {
            var atendimento = await context.Atendimentos.FirstOrDefaultAsync(d => d.Id == id);

            return atendimento;
        }
           

        public async Task<Models.Atendimento> Salvar(Models.Atendimento model)
        {
           await context.Atendimentos.AddAsync(model);
            context.SaveChanges();

            return  model;
        }
    }
}
