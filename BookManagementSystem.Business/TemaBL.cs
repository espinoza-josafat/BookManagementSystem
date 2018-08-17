using BookManagementSystem.Data;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Business
{
    public class TemaBL
    {
        public static List<Tema> ObtenerPorCoincidenciaDescripcion(string descripcion)
        {
            return TemaDAO.SelectByLikeDescripcion(descripcion);
        }
    }
}