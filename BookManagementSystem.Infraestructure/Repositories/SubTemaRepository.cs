using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories.Common;

namespace BookManagementSystem.Infraestructure.Repositories
{
    public class SubTemaRepository : Repository<SubTema>, ISubTemaRepository
    {
        public SubTemaRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}