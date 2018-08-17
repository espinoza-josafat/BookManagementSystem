using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Domain.Services
{
    public interface IAutorService : IEntityService<Autor>
    {
        Autor GetById(int id);
    }
}