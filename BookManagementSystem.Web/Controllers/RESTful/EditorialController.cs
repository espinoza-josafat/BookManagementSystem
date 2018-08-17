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
    public class EditorialController : ApiController
    {
        IEditorialService _editorialService;

        public EditorialController(IEditorialService editorialService)
        {
            _editorialService = editorialService;
        }

        [HttpGet]
        public HttpResponseMessage ObtenerPorCoincidencia(string nombre = null)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                resultado = Request.CreateResponse(HttpStatusCode.OK, EditorialBL.ObtenerPorCoincidenciaNombre(nombre));
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }

        [HttpPost]
        public HttpResponseMessage Guardar(Editorial entidad)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                if (entidad == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El modelo no puede ser nulo" });
                if (string.IsNullOrWhiteSpace(entidad.Nombre))
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El nombre no puede ser nulo o vacío" });

                if (entidad.Id > 0)
                    _editorialService.Update(entidad);
                else
                    _editorialService.Create(entidad);

                resultado = Request.CreateResponse(HttpStatusCode.OK, entidad.Id);
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }

        [HttpGet]
        public HttpResponseMessage ObtenerPorId(short id)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                resultado = Request.CreateResponse(HttpStatusCode.OK, _editorialService.GetById(id));
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }

        [HttpPost]
        public HttpResponseMessage Eliminar(Editorial entidad)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                if (entidad == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El modelo no puede ser nulo" });
                if (entidad.Id < 1)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El id debe ser amyor a 0" });

                entidad = _editorialService.GetById(entidad.Id);
                
                if (entidad != null)
                {
                    _editorialService.Delete(entidad);

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