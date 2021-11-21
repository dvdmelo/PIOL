using Metro.TelemetriaLinhas.API.Models;
using Metro.TelemetriaLinhas.API.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Metro.TelemetriaLinhas.API.Repository
{
    public class TelemetriaRepository : ITelemetriaLinhaRepository
    {
        public IEnumerable<MetroLinha> ObterSituacaoLinhas()
        {
            List<MetroLinha> linhas = new List<MetroLinha>();

            linhas.Add(new MetroLinha(LinhaEnum.Azul, SituacaoLinhaEnum.Normal));
            linhas.Add(new MetroLinha(LinhaEnum.Verde, SituacaoLinhaEnum.Normal));
            linhas.Add(new MetroLinha(LinhaEnum.Vermelha, SituacaoLinhaEnum.Normal));
            linhas.Add(new MetroLinha(LinhaEnum.Amarela, SituacaoLinhaEnum.Normal));
            linhas.Add(new MetroLinha(LinhaEnum.Lilas, SituacaoLinhaEnum.OperandoParcialmente));
            linhas.Add(new MetroLinha(LinhaEnum.Patra, SituacaoLinhaEnum.Paralizada));

            return linhas;

        }
    }
}
