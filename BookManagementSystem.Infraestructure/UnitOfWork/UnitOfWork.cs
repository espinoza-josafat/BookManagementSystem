using BookManagementSystem.Domain.UnitOfWork;
using BookManagementSystem.Infraestructure.Factories;
using System;

namespace BookManagementSystem.Infraestructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly IUnitOfWork _unitOfWork;

        public UnitOfWork(IDbFactory dbFactory)
        {
            if (dbFactory == null)
                throw new ArgumentNullException("dbFactory");

            _unitOfWork = dbFactory.Init();
        }

        public void Commit()
        {
            _unitOfWork.Commit();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}