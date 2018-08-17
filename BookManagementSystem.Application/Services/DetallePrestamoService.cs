using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Application.Services
{
    public class DetallePrestamoService : EntityService<DetallePrestamo>, IDetallePrestamoService
    {
        IUnitOfWork _unitOfWork;
        IDetallePrestamoRepository _detallePrestamoRepository;

        public DetallePrestamoService(IUnitOfWork unitOfWork, IDetallePrestamoRepository detallePrestamoRepository)
            : base(unitOfWork, detallePrestamoRepository)
        {
            _unitOfWork = unitOfWork;
            _detallePrestamoRepository = detallePrestamoRepository;
        }
    }
}