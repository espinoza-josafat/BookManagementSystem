using BookManagementSystem.Data;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Business
{
    public class SubTemaBL
    {
        public static List<SubTema> ObtenerPorCoincidenciaDescripcion(int idTema, string descripcion)
        {
            return SubTemaDAO.SelectByLikeDescripcion(idTema, descripcion);
        }
    }
}