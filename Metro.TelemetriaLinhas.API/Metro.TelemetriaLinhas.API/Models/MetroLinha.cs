using Metro.TelemetriaLinhas.API.Helpers;
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

        public int CodigoLinha { get; set; }
        public string NomeLinha { get; set; }
        public int CodigoSituacao { get; set; }
        public string Situacao { get; set; }
    }
}
