using BookManagementSystem.Data;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Business
{
    public class CategoriaBL
    {
        public static List<Categoria> ObtenerPorCoincidenciaDescripcion(string descripcion)
        {
            return CategoriaDAO.SelectByLikeDescripcion(descripcion);
        }
    }
}