using BookManagementSystem.Data.Helpers;
using BookManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace BookManagementSystem.Data
{
    public class SubCategoriaDAO
    {
        public static List<SubCategoria> SelectByLikeDescripcion(short idCategoria, string descripcion)
        {
            var resultado = new List<SubCategoria>();

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = @"spSubCategoriaBuscarPorCoincidencia";

                conexion.AddParameter(comando, "idCategoria", idCategoria);
                conexion.AddParameter(comando, "descripcion", string.IsNullOrWhiteSpace(descripcion) ? (object)DBNull.Value : descripcion);

                using (var lector = comando.ExecuteReader())
                    while (lector.Read())
                        resultado.Add(MappingDAOs.MapToClass<SubCategoria>(lector));
            }

            return resultado;
        }
    }
}