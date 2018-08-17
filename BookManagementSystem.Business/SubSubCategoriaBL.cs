using BookManagementSystem.Data;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Business
{
    public class SubSubCategoriaBL
    {
        public static List<SubSubCategoria> ObtenerPorCoincidenciaDescripcion(int idSubCategoria, string descripcion)
        {
            return SubSubCategoriaDAO.SelectByLikeDescripcion(idSubCategoria, descripcion);
        }
    }
}