using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Application.Services
{
    public class SubSubCategoriaService : EntityService<SubSubCategoria>, ISubSubCategoriaService
    {
        IUnitOfWork _unitOfWork;
        ISubSubCategoriaRepository _subSubCategoriaRepository;

        public SubSubCategoriaService(IUnitOfWork unitOfWork, ISubSubCategoriaRepository subSubCategoriaRepository)
            : base(unitOfWork, subSubCategoriaRepository)
        {
            _unitOfWork = unitOfWork;
            _subSubCategoriaRepository = subSubCategoriaRepository;
        }

        public SubSubCategoria GetById(int id)
        {
            return _subSubCategoriaRepository.GetById(id);
        }
    }
}