using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BookManagementSystem.Application.Services
{
    public class ProcesamientoTransformService : EntityService<ProcesamientoTransform>, IProcesamientoTransformService
    {
        IUnitOfWork _unitOfWork;
        IProcesamientoTransformRepository _procesamientoTransformRepository;

        public ProcesamientoTransformService(IUnitOfWork unitOfWork, IProcesamientoTransformRepository procesamientoTransformRepository)
            : base(unitOfWork, procesamientoTransformRepository)
        {
            _unitOfWork = unitOfWork;
            _procesamientoTransformRepository = procesamientoTransformRepository;
        }

        public List<ProcesamientoTransform> Obtener()
        {
            return (List<ProcesamientoTransform>)_procesamientoTransformRepository.Get();
        }

        public override void Create(ProcesamientoTransform entity)
        {
            var id = _procesamientoTransformRepository.Get().Count() == 0 ? 1 : _procesamientoTransformRepository.Get().Max(x => x.Id) + 1;

            entity.Id = id;

            base.Create(entity);
        }
    }
}