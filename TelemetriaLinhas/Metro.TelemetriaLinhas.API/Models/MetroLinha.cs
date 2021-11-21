using Metro.TelemetriaLinhas.API.Helpers;
using System.Text.Json.Serialization;

namespace Metro.TelemetriaLinhas.API.Models
{
    public class MetroLinha
    {
        MetroLinha()
        {
        }

        public MetroLinha(LinhaEnum linha, SituacaoLinhaEnum situacao)
        {
            CodigoLinha = (int)linha;
            NomeLinha = linha.GetDescription();
            CodigoSituacao = (int)situacao;
            Situacao = situacao.GetDescription();
        }

        [JsonPropertyName("CodigoLinha")]
        public int CodigoLinha { get; set; }
        [JsonPropertyName("NomeLinha")]
        public string NomeLinha { get; set; }
        [JsonPropertyName("CodigoSituacao")]
        public int CodigoSituacao { get; set; }
        [JsonPropertyName("Situacao")]
        public string Situacao { get; set; }

        [JsonPropertyName("CodNomeLinha")]
        public string CodNomeLinha
        {
            get
            {
                return string.Format("Linha {0} - {1}", CodigoLinha, NomeLinha);
            }
        }
    }
}
