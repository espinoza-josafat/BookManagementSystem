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
    public class IdiomaService : EntityService<Idioma>, IIdiomaService
    {
        IUnitOfWork _unitOfWork;
        IIdiomaRepository _idiomaRepository;

        public IdiomaService(IUnitOfWork unitOfWork, IIdiomaRepository idiomaRepository)
            : base(unitOfWork, idiomaRepository)
        {
            _unitOfWork = unitOfWork;
            _idiomaRepository = idiomaRepository;
        }

        public override IEnumerable<Idioma> Get()
        {
            ObjectCache objectCache = MemoryCache.Default;
            var result = objectCache["GetListIdiomas"] as List<Idioma>;

            if (result == null)
            {
                result = (List<Idioma>)base.Get();

                if (result != null && result.Count > 0)
                    objectCache.Set("GetListIdiomas", result, DateTime.Now.AddMinutes(6));
            }

            return result;
        }
    }
}