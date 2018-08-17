using BookManagementSystem.Data.Helpers;
using BookManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace BookManagementSystem.Data
{
    public class SubSubTemaDAO
    {
        public static List<SubSubTema> SelectByLikeDescripcion(long idSubTema, string descripcion)
        {
            var resultado = new List<SubSubTema>();

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = @"spSubSubTemaBuscarPorCoincidencia";

                conexion.AddParameter(comando, "idSubTema", idSubTema);
                conexion.AddParameter(comando, "descripcion", string.IsNullOrWhiteSpace(descripcion) ? (object)DBNull.Value : descripcion);

                using (var lector = comando.ExecuteReader())
                    while (lector.Read())
                        resultado.Add(MappingDAOs.MapToClass<SubSubTema>(lector));
            }

            return resultado;
        }
    }
}