using BookManagementSystem.Data.Helpers;
using BookManagementSystem.Entities.View;
using System;
using System.Collections.Generic;
using System.Data;

namespace BookManagementSystem.Data.View
{
    public class VWLibroDAO
    {
        public static List<VWLibro> SelectBy(long? isbn = null
                                           , string titulo = null
                                           , short? idEditorial = null
                                           , int? idAutor = null
                                           , string clavePais = null
                                           , short? idCategoria = null
                                           , int? idSubCategoria = null
                                           , int? idSubSubCategoria = null
                                           , int? idTema = null
                                           , long? idSubTema = null
                                           , long? idSubSubTema = null
                                           , byte? idIdioma = null
                                           , short? anio = null
                                           , byte? numeroEdicion = null)
        {
            var resultado = new List<VWLibro>();

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = @"spLibroBuscarPorCoincidencia";

                conexion.AddParameter(comando, "isbn", isbn ?? (object)DBNull.Value);
                conexion.AddParameter(comando, "titulo", string.IsNullOrWhiteSpace(titulo) ? (object)DBNull.Value : titulo);
                conexion.AddParameter(comando, "idEditorial", idEditorial ?? (object)DBNull.Value);
                conexion.AddParameter(comando, "idAutor", idAutor ?? (object)DBNull.Value);
                conexion.AddParameter(comando, "clavePais", string.IsNullOrWhiteSpace(clavePais) ? (object)DBNull.Value : clavePais);
                conexion.AddParameter(comando, "idCategoria", idCategoria ?? (object)DBNull.Value);
                conexion.AddParameter(comando, "idSubCategoria", idSubCategoria ?? (object)DBNull.Value);
                conexion.AddParameter(comando, "idSubSubCategoria", idSubSubCategoria ?? (object)DBNull.Value);
                conexion.AddParameter(comando, "idTema", idTema ?? (object)DBNull.Value);
                conexion.AddParameter(comando, "idSubTema", idSubTema ?? (object)DBNull.Value);
                conexion.AddParameter(comando, "idSubSubTema", idSubSubTema ?? (object)DBNull.Value);
                conexion.AddParameter(comando, "idIdioma", idIdioma ?? (object)DBNull.Value);
                conexion.AddParameter(comando, "anio", anio ?? (object)DBNull.Value);
                conexion.AddParameter(comando, "numeroEdicion", numeroEdicion ?? (object)DBNull.Value);

                using (var lector = comando.ExecuteReader())
                    while (lector.Read())
                        resultado.Add(MappingDAOs.MapToClass<VWLibro>(lector));
            }

            return resultado;
        }
    }
}