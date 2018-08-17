using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Application.Services
{
    public class TemaService : EntityService<Tema>, ITemaService
    {
        IUnitOfWork _unitOfWork;
        ITemaRepository _temaRepository;

        public TemaService(IUnitOfWork unitOfWork, ITemaRepository temaRepository)
            : base(unitOfWork, temaRepository)
        {
            _unitOfWork = unitOfWork;
            _temaRepository = temaRepository;
        }

        public Tema GetById(int id)
        {
            return _temaRepository.GetById(id);
        }
    }
}