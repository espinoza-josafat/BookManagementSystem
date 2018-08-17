using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;

namespace BookManagementSystem.Application.Services
{
    public class PaisService : EntityService<Pais>, IPaisService
    {
        IUnitOfWork _unitOfWork;
        IPaisRepository _paisRepository;

        public PaisService(IUnitOfWork unitOfWork, IPaisRepository paisRepository)
            : base(unitOfWork, paisRepository)
        {
            _unitOfWork = unitOfWork;
            _paisRepository = paisRepository;
        }

        public override IEnumerable<Pais> Get()
        {
            ObjectCache objectCache = MemoryCache.Default;
            var result = objectCache["GetListPaises"] as List<Pais>;

            if (result == null)
            {
                result = base.Get().OrderBy(x => x.Nombre).ToList();
                var top = result.Where(x => x.Clave.Equals("MEX") || x.Clave.Equals("USA")).OrderBy(x => x.Clave).ToList();
                foreach (var item in top)
                    result.Remove(item);
                result.InsertRange(0, top);

                if (result != null && result.Count > 0)
                    objectCache.Set("GetListPaises", result, DateTime.Now.AddMinutes(6));
            }

            return result;
        }
    }
}