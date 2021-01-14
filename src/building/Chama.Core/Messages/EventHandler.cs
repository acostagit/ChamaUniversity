using Chama.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chama.Core.Messages
{
    public class EventHandler : IEventHandler
    {
        private readonly IEventHandler _eventHandler;
        public EventHandler(IEventHandler eventHandler)
        {
            _eventHandler = eventHandler;
        }
        public async  Task<bool> EnviarComando<T>(T comando) where T : Command
        {
            return await _eventHandler.EnviarComando(comando);
        }

        public async Task PublicarEvent<T>(T evento) where T : Event
        {
            await _eventHandler.PublicarEvent(evento);
        }
    }
}
