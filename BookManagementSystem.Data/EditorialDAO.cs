using BookManagementSystem.Data.Helpers;
using BookManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace BookManagementSystem.Data
{
    public class EditorialDAO
    {
        public static List<Editorial> SelectByLikeNombre(string nombre)
        {
            var resultado = new List<Editorial>();

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = @"spEditorialBuscarPorCoincidencia";

                conexion.AddParameter(comando, "nombre", string.IsNullOrWhiteSpace(nombre) ? (object)DBNull.Value : nombre);

                using (var lector = comando.ExecuteReader())
                    while (lector.Read())
                        resultado.Add(MappingDAOs.MapToClass<Editorial>(lector));
            }

            return resultado;
        }
    }
}