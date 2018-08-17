using BookManagementSystem.Data;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Business
{
    public class EditorialBL
    {
        public static List<Editorial> ObtenerPorCoincidenciaNombre(string nombre)
        {
            return EditorialDAO.SelectByLikeNombre(nombre);
        }
    }
}