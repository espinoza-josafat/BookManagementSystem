using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories.Common;

namespace BookManagementSystem.Infraestructure.Repositories
{
    public class SubSubTemaRepository : Repository<SubSubTema>, ISubSubTemaRepository
    {
        public SubSubTemaRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}