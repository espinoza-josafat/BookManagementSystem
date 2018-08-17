using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories.Common;

namespace BookManagementSystem.Infraestructure.Repositories
{
    public class SubSubCategoriaRepository : Repository<SubSubCategoria>, ISubSubCategoriaRepository
    {
        public SubSubCategoriaRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}