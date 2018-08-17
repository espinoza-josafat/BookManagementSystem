using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories.Common;

namespace BookManagementSystem.Infraestructure.Repositories
{
    public class TemaRepository : Repository<Tema>, ITemaRepository
    {
        public TemaRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}