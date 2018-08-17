using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Domain.Services
{
    public interface ICodigoPostalService : IEntityService<CodigoPostal>
    {
        CodigoPostal GetByCodigo(int codigo);

        IEnumerable<CodigoPostal> GetByIdMunicipio(short idMunicipio);
    }
}