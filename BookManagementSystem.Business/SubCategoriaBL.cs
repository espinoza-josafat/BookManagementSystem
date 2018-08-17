using BookManagementSystem.Data;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Business
{
    public class SubCategoriaBL
    {
        public static List<SubCategoria> ObtenerPorCoincidenciaDescripcion(short idCategoria, string descripcion)
        {
            return SubCategoriaDAO.SelectByLikeDescripcion(idCategoria, descripcion);
        }
    }
}