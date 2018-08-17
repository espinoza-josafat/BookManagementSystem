using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Domain.Services
{
    public interface ILibroService : IEntityService<Libro>
    {
        Libro GetByISBN(long isbn);
    }
}