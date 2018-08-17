using BookManagementSystem.Domain.Repositories.Common;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Domain.Repositories
{
    public interface ICodigoPostalRepository : IRepository<CodigoPostal>
    {
        IEnumerable<CodigoPostal> GetByIdMunicipio(short idMunicipio);
    }
}