using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories.Common;

namespace BookManagementSystem.Infraestructure.Repositories
{
    public class LibroRepository : Repository<Libro>, ILibroRepository
    {
        public LibroRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}