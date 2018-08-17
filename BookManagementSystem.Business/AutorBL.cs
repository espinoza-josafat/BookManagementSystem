using BookManagementSystem.Data;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Business
{
    public class AutorBL
    {
        public static List<Autor> ObtenerPorCoincidenciaNombre(string nombre)
        {
            return AutorDAO.SelectByLikeNombre(nombre);
        }
    }
}