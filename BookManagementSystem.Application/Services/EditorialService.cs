using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Application.Services
{
    public class EditorialService : EntityService<Editorial>, IEditorialService
    {
        IUnitOfWork _unitOfWork;
        IEditorialRepository _editorialRepository;

        public EditorialService(IUnitOfWork unitOfWork, IEditorialRepository editorialRepository)
            : base(unitOfWork, editorialRepository)
        {
            _unitOfWork = unitOfWork;
            _editorialRepository = editorialRepository;
        }

        public Editorial GetById(short id)
        {
            return _editorialRepository.GetById(id);
        }
    }
}