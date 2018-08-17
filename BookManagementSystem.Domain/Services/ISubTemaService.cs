using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Domain.Services
{
    public interface ISubTemaService : IEntityService<SubTema>
    {
        SubTema GetById(long id);
    }
}