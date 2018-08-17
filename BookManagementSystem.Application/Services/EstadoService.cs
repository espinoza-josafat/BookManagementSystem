using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.Caching;

namespace BookManagementSystem.Application.Services
{
    public class EstadoService : EntityService<Estado>, IEstadoService
    {
        IUnitOfWork _unitOfWork;
        IEstadoRepository _estadoRepository;

        public EstadoService(IUnitOfWork unitOfWork, IEstadoRepository estadoRepository)
            : base(unitOfWork, estadoRepository)
        {
            _unitOfWork = unitOfWork;
            _estadoRepository = estadoRepository;
        }

        public override IEnumerable<Estado> Get()
        {
            ObjectCache objectCache = MemoryCache.Default;
            var result = objectCache["GetListEstados"] as List<Estado>;

            if (result == null)
            {
                result = (List<Estado>)base.Get();

                if (result != null && result.Count > 0)
                    objectCache.Set("GetListEstados", result, DateTime.Now.AddMinutes(6));
            }

            return result;
        }

        public Estado GetById(byte id)
        {
            return _estadoRepository.GetById(id);
        }
    }
}