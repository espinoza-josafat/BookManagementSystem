using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Application.Services
{
    public class PrestamoService : EntityService<Prestamo>, IPrestamoService
    {
        IUnitOfWork _unitOfWork;
        IPrestamoRepository _prestamoRepository;

        public PrestamoService(IUnitOfWork unitOfWork, IPrestamoRepository prestamoRepository)
            : base(unitOfWork, prestamoRepository)
        {
            _unitOfWork = unitOfWork;
            _prestamoRepository = prestamoRepository;
        }
    }
}