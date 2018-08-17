using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Domain.Services
{
    public interface IProcesamientoTransformService : IEntityService<ProcesamientoTransform>
    {
        List<ProcesamientoTransform> Obtener();
    }
}