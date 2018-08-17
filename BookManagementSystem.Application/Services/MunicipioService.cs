using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Application.Services
{
    public class MunicipioService : EntityService<Municipio>, IMunicipioService
    {
        IUnitOfWork _unitOfWork;
        IMunicipioRepository _municipioRepository;

        public MunicipioService(IUnitOfWork unitOfWork, IMunicipioRepository municipioRepository)
            : base(unitOfWork, municipioRepository)
        {
            _unitOfWork = unitOfWork;
            _municipioRepository = municipioRepository;
        }

        public Municipio GetById(short id)
        {
            return _municipioRepository.GetById(id);
        }

        public IEnumerable<Municipio> GetByIdEstado(byte idEstado)
        {
            return _municipioRepository.GetByIdEstado(idEstado);
        }
    }
}