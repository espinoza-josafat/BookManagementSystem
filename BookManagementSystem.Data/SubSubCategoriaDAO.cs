using BookManagementSystem.Data.Helpers;
using BookManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace BookManagementSystem.Data
{
    public class SubSubCategoriaDAO
    {
        public static List<SubSubCategoria> SelectByLikeDescripcion(int idSubCategoria, string descripcion)
        {
            var resultado = new List<SubSubCategoria>();

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = @"spSubSubCategoriaBuscarPorCoincidencia";

                conexion.AddParameter(comando, "idSubCategoria", idSubCategoria);
                conexion.AddParameter(comando, "descripcion", string.IsNullOrWhiteSpace(descripcion) ? (object)DBNull.Value : descripcion);

                using (var lector = comando.ExecuteReader())
                    while (lector.Read())
                        resultado.Add(MappingDAOs.MapToClass<SubSubCategoria>(lector));
            }

            return resultado;
        }
    }
}