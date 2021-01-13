using Chama.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chama.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
    }
}

