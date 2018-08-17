using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Domain.Services
{
    public interface ISubCategoriaService : IEntityService<SubCategoria>
    {
        SubCategoria GetById(int id);
    }
}