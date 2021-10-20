using System;

namespace Metro.Atendimento.Portal.Models
{
    public class Atendimento
    {
        public int Id { get; set; }
        public long NumeroProtocolo { get; set; }        
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataSolicitacao { get; set; }
    }
}
