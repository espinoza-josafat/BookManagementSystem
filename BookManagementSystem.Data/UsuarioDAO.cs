using BookManagementSystem.Data.Helpers;
using BookManagementSystem.Entities;
using System;

namespace BookManagementSystem.Data
{
    public class UsuarioDAO
    {
        public static Usuario SelectByUserName(string username)
        {
            var resultado = (Usuario)null;

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = @"SELECT [Id]
                                              ,[IdTipoUsuario]
                                              ,[Nombre]
                                              ,[ApellidoPaterno]
                                              ,[ApellidoMaterno]
                                              ,[Username]
                                              ,[Password]
                                              ,[Alta]
                                              ,[Modificacion]
                                              ,[UltimaModificacionPassword]
                                              ,[UltimaAutenticacionValida]
                                              ,[NumeroFallosAutenticacion]
                                              ,[RecuperacionPassword]
                                              ,[Nacimiento]
                                              ,[CodigoPostal]
                                              ,[NoExterior]
                                              ,[NoInterior]
                                              ,[Calle]
                                              ,[Colonia]
                                              ,[Localidad]
                                              ,[Referencia]
                                              ,[Municipio]
                                              ,[Estado]
                                              ,[Telefono1]
                                              ,[Telefono2]
                                              ,[Telefono3]
                                              ,[CorreoElectronico1]
                                              ,[CorreoElectronico2]
                                              ,[CorreoElectronico3]
                                              ,[EstaSuspendido]
                                              ,[MotivoSuspencion]
                                              ,[EstaBloqueado]
                                              ,[Activo]
                                          FROM [dbo].[Usuario]
                                         WHERE [Username]=@Username";

                conexion.AddParameter(comando, "Username", username);

                using (var lector = comando.ExecuteReader())
                    if (lector.Read())
                        resultado = MappingDAOs.MapToClass<Usuario>(lector);
            }

            return resultado;
        }

        public static int UpdateNumeroFallosAutenticacion(int id, out int numeroFallosAutenticacion)
        {
            numeroFallosAutenticacion = 0;
            var resultado = 0;

            using (var conexion = FactoryDataBase.Create())
            {
                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = @"SELECT [NumeroFallosAutenticacion]
                                              FROM [dbo].[Usuario]
                                             WHERE [Id]=@Id";

                    conexion.AddParameter(comando, "Id", id);

                    using (var lector = comando.ExecuteReader())
                    {
                        lector.Read();

                        if (!lector.IsDBNull(0))
                            numeroFallosAutenticacion = lector.GetInt32(0);
                    }
                }

                numeroFallosAutenticacion++;

                using (var comando = conexion.CreateCommand())
                {
                    comando.CommandText = @"UPDATE [dbo].[Usuario]
                                               SET [NumeroFallosAutenticacion]=@NumeroFallosAutenticacion
                                             WHERE [Id]=@Id";

                    conexion.AddParameter(comando, "NumeroFallosAutenticacion", numeroFallosAutenticacion);
                    conexion.AddParameter(comando, "Id", id);

                    resultado = comando.ExecuteNonQuery();
                }
            }

            return resultado;
        }

        public static int UpdateNumeroFallosAutenticacion(int id)
        {
            var resultado = 0;

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = @"UPDATE [dbo].[Usuario]
                                           SET [NumeroFallosAutenticacion]=@NumeroFallosAutenticacion
                                              ,[UltimaAutenticacionValida]=@UltimaAutenticacionValida
                                         WHERE [Id]=@Id";

                conexion.AddParameter(comando, "NumeroFallosAutenticacion", 0);
                conexion.AddParameter(comando, "UltimaAutenticacionValida", DateTime.UtcNow);
                conexion.AddParameter(comando, "Id", id);

                resultado = comando.ExecuteNonQuery();
            }

            return resultado;
        }

        public static int UpdateEstaBloqueado(int id)
        {
            var resultado = 0;

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = @"UPDATE [dbo].[Usuario]
                                           SET [EstaBloqueado]=@EstaBloqueado
                                         WHERE [Id]=@Id";

                conexion.AddParameter(comando, "EstaBloqueado", true);
                conexion.AddParameter(comando, "Id", id);

                resultado = comando.ExecuteNonQuery();
            }

            return resultado;
        }
    }
}