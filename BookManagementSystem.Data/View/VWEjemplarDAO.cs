using BookManagementSystem.Data.Helpers;
using BookManagementSystem.Entities.View;
using System;
using System.Collections.Generic;
using System.Data;

namespace BookManagementSystem.Data.View
{
    public class VWEjemplarDAO
    {
        public static List<VWEjemplar> SelectBy(string codigo = null, byte? idEstadoEjemplar = null)
        {
            var resultado = new List<VWEjemplar>();

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = @"spEjemplarBuscarPorCoincidencia";
                
                conexion.AddParameter(comando, "codigo", string.IsNullOrWhiteSpace(codigo) ? (object)DBNull.Value : codigo);
                conexion.AddParameter(comando, "idEstadoEjemplar", idEstadoEjemplar ?? (object)DBNull.Value);

                using (var lector = comando.ExecuteReader())
                    while (lector.Read())
                        resultado.Add(MappingDAOs.MapToClass<VWEjemplar>(lector));
            }

            return resultado;
        }
    }
}