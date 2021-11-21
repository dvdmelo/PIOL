using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro.Atendimento.Bot.Models
{
    public class OcorrenciaResponse
    {
        public int Id { get; set; }
        public long NumeroProtocolo { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public int Status { get; set; }
        public string DescricaoStatus { get; set; }
    }
}