using APIAtendimento.Models;
using APIAtendimento.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIAtendimento.Repository
{
    public class AtendimentoRepository : IAtendimentoRepository
    {
        private readonly AppDbContext context;

        public  AtendimentoRepository(AppDbContext _context)
        {
            context = _context;
        }

        public Task<List<Atendimento>> ListarTodos()
        {
            var atendimentos = context.Atendimentos.ToListAsync();

            return atendimentos;
        }

        public async Task<Atendimento> ObterPorId(int id)
        {
            var atendimento = await context.Atendimentos.FirstOrDefaultAsync(d => d.Id == id);

            return atendimento;
        }
           

        public async Task<Atendimento> Salvar(Atendimento model)
        {
           await context.Atendimentos.AddAsync(model);
            context.SaveChanges();

            return  model;
        }
    }
}
