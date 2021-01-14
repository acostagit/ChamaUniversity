using System;
using System.Collections.Generic;
using System.Text;

namespace Chama.Core.Messages
{
    //classe base
    public abstract class Command: Message
    {
        public DateTime Timestamp { get; private set; }
        public bool ValidationResult { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public virtual bool EhValido()
        {
            if (!ValidationResult) return false;

            return true;
        }
    }
}
