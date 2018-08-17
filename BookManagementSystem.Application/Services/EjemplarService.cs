using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Application.Services
{
    public class EjemplarService : EntityService<Ejemplar>, IEjemplarService
    {
        IUnitOfWork _unitOfWork;
        IEjemplarRepository _ejemplarRepository;

        public EjemplarService(IUnitOfWork unitOfWork, IEjemplarRepository ejemplarRepository)
            : base(unitOfWork, ejemplarRepository)
        {
            _unitOfWork = unitOfWork;
            _ejemplarRepository = ejemplarRepository;
        }

        public Ejemplar GetByCodigo(long codigo)
        {
            return _ejemplarRepository.GetById(codigo);
        }
    }
}