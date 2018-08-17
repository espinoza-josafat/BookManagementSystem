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
    public class TipoUsuarioService : EntityService<TipoUsuario>, ITipoUsuarioService
    {
        IUnitOfWork _unitOfWork;
        ITipoUsuarioRepository _tipoUsuarioRepository;

        public TipoUsuarioService(IUnitOfWork unitOfWork, ITipoUsuarioRepository tipoUsuarioRepository)
            : base(unitOfWork, tipoUsuarioRepository)
        {
            _unitOfWork = unitOfWork;
            _tipoUsuarioRepository = tipoUsuarioRepository;
        }

        public override IEnumerable<TipoUsuario> Get()
        {
            ObjectCache objectCache = MemoryCache.Default;
            var result = objectCache["GetListTiposUsuario"] as List<TipoUsuario>;

            if (result == null)
            {
                result = (List<TipoUsuario>)base.Get();

                if (result != null && result.Count > 0)
                    objectCache.Set("GetListTiposUsuario", result, DateTime.Now.AddMinutes(6));
            }

            return result;
        }
    }
}