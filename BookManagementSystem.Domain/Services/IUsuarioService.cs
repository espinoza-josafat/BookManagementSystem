using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Domain.Services
{
    public interface IUsuarioService : IEntityService<Usuario>
    {
        Usuario GetById(int id);
    }
}