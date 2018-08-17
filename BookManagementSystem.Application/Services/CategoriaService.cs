using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Application.Services
{
    public class CategoriaService : EntityService<Categoria>, ICategoriaService
    {
        IUnitOfWork _unitOfWork;
        ICategoriaRepository _categoriaRepository;

        public CategoriaService(IUnitOfWork unitOfWork, ICategoriaRepository categoriaRepository)
            : base(unitOfWork, categoriaRepository)
        {
            _unitOfWork = unitOfWork;
            _categoriaRepository = categoriaRepository;
        }

        public Categoria GetById(short id)
        {
            return _categoriaRepository.GetById(id);
        }
    }
}