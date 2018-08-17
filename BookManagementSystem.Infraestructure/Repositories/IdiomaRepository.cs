using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories.Common;

namespace BookManagementSystem.Infraestructure.Repositories
{
    public class IdiomaRepository : Repository<Idioma>, IIdiomaRepository
    {
        public IdiomaRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}