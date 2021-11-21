using Metro.Atendimento.Bot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro.Atendimento.Bot.Services
{
    public class Ocorrencia
    {
        public OcorrenciaResponse CriarOcorrencia(Models.OcorrenciaRequest ocorrencia)
        {
            Repository.Ocorrencia repOcorrencia = new Repository.Ocorrencia();
            return  repOcorrencia.PostOcorrencia(ocorrencia);
        }
    }
}
