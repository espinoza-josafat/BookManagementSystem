using BookManagementSystem.Data.Helpers;
using BookManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace BookManagementSystem.Data
{
    public class AutorDAO
    {
        public static List<Autor> SelectByLikeNombre(string nombre)
        {
            var resultado = new List<Autor>();

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = @"spAutorBuscarPorCoincidencia";

                conexion.AddParameter(comando, "nombre", string.IsNullOrWhiteSpace(nombre) ? (object)DBNull.Value : nombre);

                using (var lector = comando.ExecuteReader())
                    while (lector.Read())
                        resultado.Add(MappingDAOs.MapToClass<Autor>(lector));
            }

            return resultado;
        }
    }
}