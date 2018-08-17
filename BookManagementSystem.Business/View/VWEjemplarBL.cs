using BookManagementSystem.Data.View;
using BookManagementSystem.Entities.View;
using System.Collections.Generic;

namespace BookManagementSystem.Business.View
{
    public class VWEjemplarBL
    {
        public static List<VWEjemplar> ObtenerPor(string codigo = null, byte? idEstadoEjemplar = null)
        {
            return VWEjemplarDAO.SelectBy(codigo, idEstadoEjemplar);
        }
    }
}