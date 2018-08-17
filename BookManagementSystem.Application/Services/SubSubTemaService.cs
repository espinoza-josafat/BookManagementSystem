using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Application.Services
{
    public class SubSubTemaService : EntityService<SubSubTema>, ISubSubTemaService
    {
        IUnitOfWork _unitOfWork;
        ISubSubTemaRepository _subSubTemaRepository;

        public SubSubTemaService(IUnitOfWork unitOfWork, ISubSubTemaRepository subSubTemaRepository)
            : base(unitOfWork, subSubTemaRepository)
        {
            _unitOfWork = unitOfWork;
            _subSubTemaRepository = subSubTemaRepository;
        }

        public SubSubTema GetById(long id)
        {
            return _subSubTemaRepository.GetById(id);
        }
    }
}