using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Domain.Services
{
    public interface IEjemplarService : IEntityService<Ejemplar>
    {
        Ejemplar GetByCodigo(long codigo);
    }
}