using BookManagementSystem.Domain.Repositories.Common;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Domain.Repositories
{
    public interface IMunicipioRepository : IRepository<Municipio>
    {
        IEnumerable<Municipio> GetByIdEstado(byte idEstado);
    }
}