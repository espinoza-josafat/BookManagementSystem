using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Domain.Services
{
    public interface ISubSubTemaService : IEntityService<SubSubTema>
    {
        SubSubTema GetById(long id);
    }
}