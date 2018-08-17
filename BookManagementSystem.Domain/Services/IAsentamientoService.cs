using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Domain.Services
{
    public interface IAsentamientoService : IEntityService<Asentamiento>
    {
        Asentamiento GetById(int id);

        IEnumerable<Asentamiento> GetByCodigo(int codigo);
    }
}