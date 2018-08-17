using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Entities;
using BookManagementSystem.Infraestructure.Factories;
using BookManagementSystem.Infraestructure.Repositories.Common;

namespace BookManagementSystem.Infraestructure.Repositories
{
    public class ProcesamientoTransformRepository : Repository<ProcesamientoTransform>, IProcesamientoTransformRepository
    {
        public ProcesamientoTransformRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}