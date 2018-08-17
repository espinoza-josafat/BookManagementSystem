using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Application.Services
{
    public class AsentamientoService : EntityService<Asentamiento>, IAsentamientoService
    {
        IUnitOfWork _unitOfWork;
        IAsentamientoRepository _asentamientoRepository;

        public AsentamientoService(IUnitOfWork unitOfWork, IAsentamientoRepository asentamientoRepository)
            : base(unitOfWork, asentamientoRepository)
        {
            _unitOfWork = unitOfWork;
            _asentamientoRepository = asentamientoRepository;
        }

        public Asentamiento GetById(int id)
        {
            return _asentamientoRepository.GetById(id);
        }

        public IEnumerable<Asentamiento> GetByCodigo(int codigo)
        {
            return _asentamientoRepository.GetByCodigo(codigo);
        }
    }
}