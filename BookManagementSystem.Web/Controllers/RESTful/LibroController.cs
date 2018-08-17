using BookManagementSystem.Business;
using BookManagementSystem.Business.View;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Entities;
using BookManagementSystem.Web.Attributes;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookManagementSystem.Web.Controllers.RESTful
{
    [AuthorizeApiSession]
    public class LibroController : ApiController
    {
        ILibroService _libroService;

        public LibroController(ILibroService libroService)
        {
            _libroService = libroService;
        }

        [HttpGet]
        public HttpResponseMessage Consultar(long? isbn = null
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
            var resultado = (HttpResponseMessage)null;

            try
            {
                resultado = Request.CreateResponse(HttpStatusCode.OK, VWLibroBL.ObtenerPor(isbn
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
                                                                                           , numeroEdicion));
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }

        [HttpPost]
        public HttpResponseMessage Guardar(Libro entidad)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                if (entidad == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El modelo no puede ser nulo" });

                if (entidad.Edicion)
                {
                    entidad.NumeroEjemplares = LibroBL.ObtenerPorISBN(entidad.ISBN).NumeroEjemplares;
                    _libroService.Update(entidad);
                }
                else
                {
                    entidad.NumeroEjemplares = 0;
                    entidad.Estatus = 1;
                    _libroService.Create(entidad);
                }

                resultado = Request.CreateResponse(HttpStatusCode.OK, entidad);
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }

        [HttpPost]
        public HttpResponseMessage Eliminar(Libro entidad)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                if (entidad == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El modelo no puede ser nulo" });
                if (entidad.ISBN < 1)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El GetByISBN debe ser amyor a 0" });

                entidad = _libroService.GetByISBN(entidad.ISBN);

                if (entidad != null)
                {
                    _libroService.Delete(entidad);

                    resultado = Request.CreateResponse(HttpStatusCode.OK, 1);
                }
                else
                    resultado = Request.CreateResponse(HttpStatusCode.OK, 0);
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }
    }
}