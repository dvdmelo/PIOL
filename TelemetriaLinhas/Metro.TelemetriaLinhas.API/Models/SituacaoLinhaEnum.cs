using System.ComponentModel;

namespace Metro.TelemetriaLinhas.API.Models
{
    public enum SituacaoLinhaEnum
    {
        [Description("Operação Normal")]
        Normal = 1,
        [Description("Operando Parcialmente")]
        OperandoParcialmente = 2,
        [Description("Paralizada")]
        Paralizada = 3
    }
}
