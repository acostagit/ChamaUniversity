using System;
using System.Collections.Generic;
using System.Text;

namespace Chama.Core.DomainObjects
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
    }
}
