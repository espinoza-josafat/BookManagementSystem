using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories.Common;
using System.Collections.Generic;
using System.Linq;

namespace BookManagementSystem.Infraestructure.Repositories
{
    public class MunicipioRepository : Repository<Municipio>, IMunicipioRepository
    {
        public MunicipioRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<Municipio> GetByIdEstado(byte idEstado)
        {
            return _dbSet.Where(x => x.IdEstado == idEstado).ToList();
        }
    }
}