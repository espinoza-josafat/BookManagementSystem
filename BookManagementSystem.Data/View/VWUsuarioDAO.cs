using BookManagementSystem.Data.Helpers;
using BookManagementSystem.Entities.View;
using System;
using System.Collections.Generic;
using System.Data;

namespace BookManagementSystem.Data.View
{
    public class VWUsuarioDAO
    {
        public static List<VWUsuario> SelectBy(string nombre = null, byte? idTipoUsuario = null)
        {
            var resultado = new List<VWUsuario>();

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = @"spUsuarioBuscarPorCoincidencia";

                conexion.AddParameter(comando, "nombre", string.IsNullOrWhiteSpace(nombre) ? (object)DBNull.Value : nombre);
                conexion.AddParameter(comando, "idTipoUsuario", idTipoUsuario ?? (object)DBNull.Value);

                using (var lector = comando.ExecuteReader())
                    while (lector.Read())
                        resultado.Add(MappingDAOs.MapToClass<VWUsuario>(lector));
            }

            return resultado;
        }
    }
}