using BookManagementSystem.Data;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Business
{
    public class LibroBL
    {
        public static Libro ObtenerPorISBN(long isbn)
        {
            return LibroDAO.SelectByISBN(isbn);
        }
    }
}