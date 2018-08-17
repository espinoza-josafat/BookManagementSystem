using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories.Common;
using System.Collections.Generic;
using System.Linq;

namespace BookManagementSystem.Infraestructure.Repositories
{
    public class CodigoPostalRepository : Repository<CodigoPostal>, ICodigoPostalRepository
    {
        public CodigoPostalRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<CodigoPostal> GetByIdMunicipio(short idMunicipio)
        {
            return _dbSet.Where(x => x.IdMunicipio == idMunicipio).ToList();
        }
    }
}