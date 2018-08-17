using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Domain.Services
{
    public interface IMunicipioService : IEntityService<Municipio>
    {
        Municipio GetById(short id);

        IEnumerable<Municipio> GetByIdEstado(byte idEstado);
    }
}