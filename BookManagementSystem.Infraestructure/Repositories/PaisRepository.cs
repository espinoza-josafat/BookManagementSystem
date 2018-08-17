using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories.Common;

namespace BookManagementSystem.Infraestructure.Repositories
{
    public class PaisRepository : Repository<Pais>, IPaisRepository
    {
        public PaisRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}