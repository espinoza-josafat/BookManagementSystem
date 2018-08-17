using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories.Common;

namespace BookManagementSystem.Infraestructure.Repositories
{
    public class EstadoEjemplarRepository : Repository<EstadoEjemplar>, IEstadoEjemplarRepository
    {
        public EstadoEjemplarRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}