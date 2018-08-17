using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Domain.Services
{
    public interface ICategoriaService : IEntityService<Categoria>
    {
        Categoria GetById(short id);
    }
}