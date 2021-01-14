using Chama.Core.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chama.Core.DomainObjects
{
    public interface IEventHandler
    {
        Task PublicarEvent<T>(T evento) where T : Event;

        Task<bool> EnviarComando<T>(T comando) where T : Command;
    }
}
