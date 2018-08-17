using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Domain.Services
{
    public interface ITemaService : IEntityService<Tema>
    {
        Tema GetById(int id);
    }
}