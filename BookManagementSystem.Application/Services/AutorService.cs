using BookManagementSystem.Domain.Repositories;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Domain.Services.Common;
using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Application.Services
{
    public class AutorService : EntityService<Autor>, IAutorService
    {
        IUnitOfWork _unitOfWork;
        IAutorRepository _autorRepository;

        public AutorService(IUnitOfWork unitOfWork, IAutorRepository autorRepository)
            : base(unitOfWork, autorRepository)
        {
            _unitOfWork = unitOfWork;
            _autorRepository = autorRepository;
        }

        public Autor GetById(int id)
        {
            return _autorRepository.GetById(id);
        }
    }
}