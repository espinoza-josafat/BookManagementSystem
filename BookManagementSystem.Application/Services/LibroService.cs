using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Application.Services
{
    public class LibroService : EntityService<Libro>, ILibroService
    {
        IUnitOfWork _unitOfWork;
        ILibroRepository _libroRepository;

        public LibroService(IUnitOfWork unitOfWork, ILibroRepository libroRepository)
            : base(unitOfWork, libroRepository)
        {
            _unitOfWork = unitOfWork;
            _libroRepository = libroRepository;
        }

        public Libro GetByISBN(long isbn)
        {
            return _libroRepository.GetById(isbn);
        }
    }
}