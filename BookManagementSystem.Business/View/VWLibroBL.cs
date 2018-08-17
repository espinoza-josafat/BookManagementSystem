using BookManagementSystem.Data.View;
using BookManagementSystem.Entities.View;
using System.Collections.Generic;

namespace BookManagementSystem.Business.View
{
    public class VWLibroBL
    {
        public static List<VWLibro> ObtenerPor(long? isbn = null
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
            return VWLibroDAO.SelectBy(isbn
                                       , titulo
                                       , idEditorial
                                       , idAutor
                                       , clavePais
                                       , idCategoria
                                       , idSubCategoria
                                       , idSubSubCategoria
                                       , idTema
                                       , idSubTema
                                       , idSubSubTema
                                       , idIdioma
                                       , anio
                                       , numeroEdicion);
        }
    }
}