using Metro.TelemetriaLinhas.API.Models;
using System.Collections.Generic;

namespace Metro.TelemetriaLinhas.API.Services.Interface
{
    public interface ITelemetriaService
    {
        IEnumerable<MetroLinha> ObterSituacaoLinhas();
    }
}
