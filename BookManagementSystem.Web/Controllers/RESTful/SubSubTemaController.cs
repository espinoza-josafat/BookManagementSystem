using BookManagementSystem.Business;
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
    public class SubSubTemaController : ApiController
    {
        ISubSubTemaService _subSubTemaService;

        public SubSubTemaController(ISubSubTemaService subSubTemaService)
        {
            _subSubTemaService = subSubTemaService;
        }

        [HttpGet]
        public HttpResponseMessage ObtenerPorCoincidencia(long subTema, string descripcion = null)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                resultado = Request.CreateResponse(HttpStatusCode.OK, SubSubTemaBL.ObtenerPorCoincidenciaDescripcion(subTema, descripcion));
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }

        [HttpPost]
        public HttpResponseMessage Guardar(SubSubTema entidad)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                if (entidad == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El modelo no puede ser nulo" });
                if (string.IsNullOrWhiteSpace(entidad.Descripcion))
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "La descripción no puede ser nula o vacía" });

                if (entidad.Id > 0)
                    _subSubTemaService.Update(entidad);
                else
                    _subSubTemaService.Create(entidad);

                resultado = Request.CreateResponse(HttpStatusCode.OK, entidad.Id);
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }

        [HttpGet]
        public HttpResponseMessage ObtenerPorId(long id)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                resultado = Request.CreateResponse(HttpStatusCode.OK, _subSubTemaService.GetById(id));
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }

        [HttpPost]
        public HttpResponseMessage Eliminar(SubSubTema entidad)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                if (entidad == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El modelo no puede ser nulo" });
                if (entidad.Id < 1)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El id debe ser amyor a 0" });

                entidad = _subSubTemaService.GetById(entidad.Id);

                if (entidad != null)
                {
                    _subSubTemaService.Delete(entidad);

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