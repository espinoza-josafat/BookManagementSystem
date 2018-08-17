using BookManagementSystem.Data.Helpers;
using BookManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace BookManagementSystem.Data
{
    public class SubTemaDAO
    {
        public static List<SubTema> SelectByLikeDescripcion(int idTema, string descripcion)
        {
            var resultado = new List<SubTema>();

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = @"spSubTemaBuscarPorCoincidencia";

                conexion.AddParameter(comando, "idTema", idTema);
                conexion.AddParameter(comando, "descripcion", string.IsNullOrWhiteSpace(descripcion) ? (object)DBNull.Value : descripcion);

                using (var lector = comando.ExecuteReader())
                    while (lector.Read())
                        resultado.Add(MappingDAOs.MapToClass<SubTema>(lector));
            }

            return resultado;
        }
    }
}