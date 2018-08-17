using BookManagementSystem.Data.Helpers;
using BookManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace BookManagementSystem.Data
{
    public class CategoriaDAO
    {
        public static List<Categoria> SelectByLikeDescripcion(string descripcion)
        {
            var resultado = new List<Categoria>();

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = @"spCategoriaBuscarPorCoincidencia";

                conexion.AddParameter(comando, "descripcion", string.IsNullOrWhiteSpace(descripcion) ? (object)DBNull.Value : descripcion);

                using (var lector = comando.ExecuteReader())
                    while (lector.Read())
                        resultado.Add(MappingDAOs.MapToClass<Categoria>(lector));
            }

            return resultado;
        }
    }
}