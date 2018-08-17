using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Application.Services
{
    public class SubCategoriaService : EntityService<SubCategoria>, ISubCategoriaService
    {
        IUnitOfWork _unitOfWork;
        ISubCategoriaRepository _subCategoriaRepository;

        public SubCategoriaService(IUnitOfWork unitOfWork, ISubCategoriaRepository subCategoriaRepository)
            : base(unitOfWork, subCategoriaRepository)
        {
            _unitOfWork = unitOfWork;
            _subCategoriaRepository = subCategoriaRepository;
        }

        public SubCategoria GetById(int id)
        {
            return _subCategoriaRepository.GetById(id);
        }
    }
}