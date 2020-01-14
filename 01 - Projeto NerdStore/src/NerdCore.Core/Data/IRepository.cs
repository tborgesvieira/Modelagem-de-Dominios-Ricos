using NerdCore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NerdCore.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }

    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
