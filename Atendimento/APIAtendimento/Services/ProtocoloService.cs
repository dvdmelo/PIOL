using Metro.Atendimento.Portal.Services.Interface;
using System;

namespace Metro.Atendimento.Portal.Services
{
    public class ProtocoloService : IProtocoloService
    {
        public long GerarProtocolo()
        {
            return long.Parse(string.Format("{0}", DateTime.Now.ToString("yyyyMMddHHmmsss")));
        }
    }
}
