using Metro.TelemetriaLinhas.API.Models;
using Metro.TelemetriaLinhas.API.Repository.Interface;
using Metro.TelemetriaLinhas.API.Services.Interface;
using System.Collections.Generic;

namespace Metro.TelemetriaLinhas.API.Services
{
    public class TelemetriaLinhaService : ITelemetriaService
    {
        private readonly ITelemetriaLinhaRepository telemetriaLinhaRepository;
        public TelemetriaLinhaService(ITelemetriaLinhaRepository _telemetriaLinhaRepository)
        {
            telemetriaLinhaRepository = _telemetriaLinhaRepository;
        }

        public IEnumerable<MetroLinha> ObterSituacaoLinhas()
        {
            return telemetriaLinhaRepository.ObterSituacaoLinhas();
        }
    }
}
