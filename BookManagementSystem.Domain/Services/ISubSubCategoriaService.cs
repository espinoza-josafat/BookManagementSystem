using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Domain.Services
{
    public interface ISubSubCategoriaService : IEntityService<SubSubCategoria>
    {
        SubSubCategoria GetById(int id);
    }
}