using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Application.Services
{
    public class CodigoPostalService : EntityService<CodigoPostal>, ICodigoPostalService
    {
        IUnitOfWork _unitOfWork;
        ICodigoPostalRepository _codigoPostalRepository;

        public CodigoPostalService(IUnitOfWork unitOfWork, ICodigoPostalRepository codigoPostalRepository)
            : base(unitOfWork, codigoPostalRepository)
        {
            _unitOfWork = unitOfWork;
            _codigoPostalRepository = codigoPostalRepository;
        }
        
        public CodigoPostal GetByCodigo(int codigo)
        {
            return _codigoPostalRepository.GetById(codigo);
        }

        public IEnumerable<CodigoPostal> GetByIdMunicipio(short idMunicipio)
        {
            return _codigoPostalRepository.GetByIdMunicipio(idMunicipio);
        }
    }
}