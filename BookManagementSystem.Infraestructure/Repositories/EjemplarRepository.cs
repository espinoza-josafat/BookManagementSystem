using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories.Common;

namespace BookManagementSystem.Infraestructure.Repositories
{
    public class EjemplarRepository : Repository<Ejemplar>, IEjemplarRepository
    {
        public EjemplarRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}