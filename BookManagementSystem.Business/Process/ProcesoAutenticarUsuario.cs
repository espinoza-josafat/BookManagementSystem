using BookManagementSystem.Tools.Exceptions;
using BookManagementSystem.Data;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Business.Process
{
    public class ProcesoAutenticarUsuario
    {
        public Usuario Ejecutar(string username, string password)
        {
            var resultado = (Usuario)null;

            resultado = UsuarioDAO.SelectByUserName(username);

            if (resultado == null)
                throw new BusinessLogicException("El usuario no existe");
            if (!resultado.Activo)
                throw new BusinessLogicException("Este usuario ya no esta activo, ponte en contacto con el administrador");
            if (resultado.EstaBloqueado)
                throw new BusinessLogicException("Este usuario esta bloqueado");

            if (!password.Equals(resultado.Password))
            {
                int numeroFallosAutenticacion = 0;
                UsuarioDAO.UpdateNumeroFallosAutenticacion(resultado.Id, out numeroFallosAutenticacion);

                if (numeroFallosAutenticacion == 5)
                {
                    UsuarioDAO.UpdateEstaBloqueado(resultado.Id);
                    throw new BusinessLogicException("Este usuario esta bloqueado");
                }
                else
                    throw new BusinessLogicException("No es correcta la contraseña");
            }

            UsuarioDAO.UpdateNumeroFallosAutenticacion(resultado.Id);
            
            return resultado;
        }
    }
}