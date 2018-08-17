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
    public class EjemplarController : ApiController
    {
        IEjemplarService _ejemplarService;

        public EjemplarController(IEjemplarService ejemplarService)
        {
            _ejemplarService = ejemplarService;
        }

        [HttpGet]
        public HttpResponseMessage ObtenerPorCoincidencia(long? codigo = null, byte? idEstadoEjemplar = null)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                resultado = Request.CreateResponse(HttpStatusCode.OK, VWEjemplarBL.ObtenerPor((codigo.HasValue ? codigo.Value.ToString() : null)
                                                                                           , idEstadoEjemplar));
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }

        [HttpPost]
        public HttpResponseMessage Guardar(Ejemplar entidad)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                if (entidad == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El modelo no puede ser nulo" });

                if (entidad.Edicion)
                    _ejemplarService.Update(entidad);
                else
                {
                    entidad.Estatus = 1;
                    _ejemplarService.Create(entidad);
                }

                resultado = Request.CreateResponse(HttpStatusCode.OK, entidad.Codigo);
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }

        [HttpGet]
        public HttpResponseMessage ObtenerPorCodigo(long codigo)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                resultado = Request.CreateResponse(HttpStatusCode.OK, _ejemplarService.GetByCodigo(codigo));
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }

        [HttpPost]
        public HttpResponseMessage Eliminar(Ejemplar entidad)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                if (entidad == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El modelo no puede ser nulo" });
                if (entidad.Codigo < 1)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El código debe ser amyor a 0" });

                entidad = _ejemplarService.GetByCodigo(entidad.Codigo);

                if (entidad != null)
                {
                    _ejemplarService.Delete(entidad);

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