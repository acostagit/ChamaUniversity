﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Chama.Core.Messages
{
    public interface Event
    {
        Task PublicarEvent<T>(T evento) where T : Event;

        Task<bool> EnviarComando<T>(T comando) where T : Command;
    }
}
