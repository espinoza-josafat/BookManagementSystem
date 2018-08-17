using BookManagementSystem.Infraestructure.DbContext;

namespace BookManagementSystem.Infraestructure.Factories
{
    public class DbFactory : Disposable, IDbFactory
    {
        IBookManagementSystemDbContext _unitOfWork;

        public IBookManagementSystemDbContext Init()
        {
            if (_unitOfWork == null)
                _unitOfWork = new BookManagementSystemDbContext();

            return _unitOfWork;
        }

        protected override void DisposeCore()
        {
            if (_unitOfWork != null)
                _unitOfWork.Dispose();
        }
    }
}