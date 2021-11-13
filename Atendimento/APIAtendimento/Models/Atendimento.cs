using System;
using System.Text.Json.Serialization;

namespace Metro.Atendimento.Portal.Models
{
    public class Atendimento
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("NumeroProtocolo")]
        public long NumeroProtocolo { get; set; }
        [JsonPropertyName("Assunto")]
        public string Assunto { get; set; }
        [JsonPropertyName("Mensagem")]
        public string Mensagem { get; set; }
        [JsonPropertyName("DataSolicitacao")]
        public DateTime DataSolicitacao { get; set; }
        [JsonPropertyName("Status")]
        public int Status { get; set; }
        [JsonPropertyName("DescricaoStatus")]
        public string DescricaoStatus
        {
            get
            {
                switch (Status)
                {
                    case (int)StatusAtendimento.PendenteAnalise:
                        return "Pendente Analise";
                    case (int)StatusAtendimento.EmAnalise:
                        return "Em Analise";
                    case (int)StatusAtendimento.Concluido:
                        return "Concluído";
                    default:
                        return "";

                }
            }
        }
    }
}
