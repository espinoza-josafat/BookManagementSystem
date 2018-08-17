using BookManagementSystem.Data.Helpers;
using BookManagementSystem.Entities;

namespace BookManagementSystem.Data
{
    public class LibroDAO
    {
        public static Libro SelectByISBN(long isbn)
        {
            var resultado = (Libro)null;

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = @"SELECT [ISBN]
                                              ,[IdEditorial]
                                              ,[IdAutor]
                                              ,[ClavePais]
                                              ,[IdIdioma]
                                              ,[IdCategoria]
                                              ,[IdSubCategoria]
                                              ,[IdSubSubCategoria]
                                              ,[IdTema]
                                              ,[IdSubTema]
                                              ,[IdSubSubTema]
                                              ,[Titulo]
                                              ,[FechaPublicacion]
                                              ,[Anio]
                                              ,[Paginas]
                                              ,[NumeroEdicion]
                                              ,[NumeroEjemplares]
                                              ,[Estatus]
                                          FROM [dbo].[Libro]
                                         WHERE [ISBN]=@ISBN";

                conexion.AddParameter(comando, "ISBN", isbn);

                using (var lector = comando.ExecuteReader())
                    if (lector.Read())
                        resultado = MappingDAOs.MapToClass<Libro>(lector);
            }

            return resultado;
        }
    }
}