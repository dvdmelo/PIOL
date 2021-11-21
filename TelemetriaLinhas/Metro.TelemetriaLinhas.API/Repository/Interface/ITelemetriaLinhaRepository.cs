using Metro.TelemetriaLinhas.API.Models;
using System.Collections.Generic;

namespace Metro.TelemetriaLinhas.API.Repository.Interface
{
    public interface ITelemetriaLinhaRepository
    {
        IEnumerable<MetroLinha> ObterSituacaoLinhas();
    }
}
