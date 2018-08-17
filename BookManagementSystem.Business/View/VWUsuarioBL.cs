using BookManagementSystem.Data.View;
using BookManagementSystem.Entities.View;
using System.Collections.Generic;

namespace BookManagementSystem.Business.View
{
    public class VWUsuarioBL
    {
        public static List<VWUsuario> ObtenerPor(string nombre = null, byte? idTipoUsuario = null)
        {
            return VWUsuarioDAO.SelectBy(nombre, idTipoUsuario);
        }
    }
}