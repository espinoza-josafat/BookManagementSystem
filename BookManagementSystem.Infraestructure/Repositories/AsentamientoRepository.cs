using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories.Common;
using System.Collections.Generic;
using System.Linq;

namespace BookManagementSystem.Infraestructure.Repositories
{
    public class AsentamientoRepository : Repository<Asentamiento>, IAsentamientoRepository
    {
        public AsentamientoRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<Asentamiento> GetByCodigo(int codigo)
        {
            return _dbSet.Where(x => x.Codigo == codigo).ToList();
        }
    }
}