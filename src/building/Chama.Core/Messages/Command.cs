using System;
using System.Collections.Generic;
using System.Text;

namespace Chama.Core.Messages
{
    //classe base
    public abstract class Command
    {
        public DateTime Timestamp { get; private set; }
    }
}
