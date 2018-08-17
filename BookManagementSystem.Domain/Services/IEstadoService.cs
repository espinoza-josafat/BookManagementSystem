using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Domain.Services
{
    public interface IEstadoService : IEntityService<Estado>
    {
        Estado GetById(byte id);
    }
}