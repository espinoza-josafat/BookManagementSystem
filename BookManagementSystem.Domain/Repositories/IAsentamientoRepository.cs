using BookManagementSystem.Domain.Repositories.Common;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Domain.Repositories
{
    public interface IAsentamientoRepository : IRepository<Asentamiento>
    {
        IEnumerable<Asentamiento> GetByCodigo(int codigo);
    }
}