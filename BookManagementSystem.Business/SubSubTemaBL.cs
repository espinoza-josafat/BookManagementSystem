using BookManagementSystem.Data;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Business
{
    public class SubSubTemaBL
    {
        public static List<SubSubTema> ObtenerPorCoincidenciaDescripcion(long idSubTema, string descripcion)
        {
            return SubSubTemaDAO.SelectByLikeDescripcion(idSubTema, descripcion);
        }
    }
}