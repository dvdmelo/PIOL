using System;

namespace APIAtendimento.Models
{
    public class Atendimento
    {
        public int Id { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}
