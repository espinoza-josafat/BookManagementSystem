using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories.Common;

namespace BookManagementSystem.Infraestructure.Repositories
{
    public class DetallePrestamoRepository : Repository<DetallePrestamo>, IDetallePrestamoRepository
    {
        public DetallePrestamoRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}