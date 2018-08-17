using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Domain.Services
{
    public interface IEditorialService : IEntityService<Editorial>
    {
        Editorial GetById(short id);
    }
}