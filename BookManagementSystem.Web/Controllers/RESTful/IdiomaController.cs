using BookManagementSystem.Domain.Services;
using BookManagementSystem.Web.Attributes;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookManagementSystem.Web.Controllers.RESTful
{
    [AuthorizeApiSession]
    public class IdiomaController : ApiController
    {
        IIdiomaService _idiomaService;

        public IdiomaController(IIdiomaService idiomaService)
        {
            _idiomaService = idiomaService;
        }

        [HttpGet]
        public HttpResponseMessage Obtener()
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                resultado = Request.CreateResponse(HttpStatusCode.OK, _idiomaService.Get());
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }
    }
}