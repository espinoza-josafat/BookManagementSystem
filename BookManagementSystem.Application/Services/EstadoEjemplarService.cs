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
    public class EstadoEjemplarService : EntityService<EstadoEjemplar>, IEstadoEjemplarService
    {
        IUnitOfWork _unitOfWork;
        IEstadoEjemplarRepository _estadoEjemplarRepository;

        public EstadoEjemplarService(IUnitOfWork unitOfWork, IEstadoEjemplarRepository estadoEjemplarRepository)
            : base(unitOfWork, estadoEjemplarRepository)
        {
            _unitOfWork = unitOfWork;
            _estadoEjemplarRepository = estadoEjemplarRepository;
        }

        public override IEnumerable<EstadoEjemplar> Get()
        {
            ObjectCache objectCache = MemoryCache.Default;
            var result = objectCache["GetListEstadosEjemplar"] as List<EstadoEjemplar>;

            if (result == null)
            {
                result = (List<EstadoEjemplar>)base.Get();

                if (result != null && result.Count > 0)
                    objectCache.Set("GetListEstadosEjemplar", result, DateTime.Now.AddMinutes(6));
            }

            return result;
        }
    }
}