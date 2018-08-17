using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Application.Services
{
    public class SubTemaService : EntityService<SubTema>, ISubTemaService
    {
        IUnitOfWork _unitOfWork;
        ISubTemaRepository _subTemaRepository;

        public SubTemaService(IUnitOfWork unitOfWork, ISubTemaRepository subTemaRepository)
            : base(unitOfWork, subTemaRepository)
        {
            _unitOfWork = unitOfWork;
            _subTemaRepository = subTemaRepository;
        }

        public SubTema GetById(long id)
        {
            return _subTemaRepository.GetById(id);
        }
    }
}