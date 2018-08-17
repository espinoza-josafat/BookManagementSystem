using BookManagementSystem.Domain.Services;
using BookManagementSystem.Web.Attributes;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookManagementSystem.Web.Controllers.RESTful
{
    [AuthorizeApiSession]
    public class EstadoEjemplarController : ApiController
    {
        IEstadoEjemplarService _estadoEjemplarService;

        public EstadoEjemplarController(IEstadoEjemplarService estadoEjemplarService)
        {
            _estadoEjemplarService = estadoEjemplarService;
        }

        [HttpGet]
        public HttpResponseMessage Obtener()
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                resultado = Request.CreateResponse(HttpStatusCode.OK, _estadoEjemplarService.Get());
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }
    }
}