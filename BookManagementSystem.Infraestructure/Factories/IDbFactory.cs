using BookManagementSystem.Infraestructure.DbContext;
using System;

namespace BookManagementSystem.Infraestructure.Factories
{
    public interface IDbFactory : IDisposable
    {
        IBookManagementSystemDbContext Init();
    }
}