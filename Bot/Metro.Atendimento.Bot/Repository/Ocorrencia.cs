using Metro.Atendimento.Bot.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metro.Atendimento.Bot.Repository
{
    public class Ocorrencia
    {
        public OcorrenciaResponse PostOcorrencia(OcorrenciaRequest ocorrencia)
        {
            string json = JsonConvert.SerializeObject(ocorrencia);

            var client = new RestClient("https://apiatendimento.azurewebsites.net/v1/atendimentos");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return JsonConvert.DeserializeObject<OcorrenciaResponse>(response.Content);
        }
    }
}
