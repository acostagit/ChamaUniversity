using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chama.Core.Messages.Integration
{
    public class IntegrationEvent : Event
    {
        public Task<bool> EnviarComando<T>(T comando) where T : Command
        {
            throw new NotImplementedException();
        }

        public Task PublicarEvent<T>(T evento) where T : Event
        {
            throw new NotImplementedException();
        }
    }
}
