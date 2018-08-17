using BookManagementSystem.Domain.Services;
using BookManagementSystem.Web.Attributes;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookManagementSystem.Web.Controllers.RESTful
{
    [AuthorizeApiSession]
    public class CodigoPostalController : ApiController
    {
        ICodigoPostalService _codigoPostalService;

        public CodigoPostalController(ICodigoPostalService codigoPostalService)
        {
            _codigoPostalService = codigoPostalService;
        }

        [HttpGet]
        public HttpResponseMessage ObtenerPorIdMunicipio(short idMunicipio)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                resultado = Request.CreateResponse(HttpStatusCode.OK, _codigoPostalService.GetByIdMunicipio(idMunicipio));
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }

        [HttpGet]
        public HttpResponseMessage ObtenerPorCodigo(int codigo)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                resultado = Request.CreateResponse(HttpStatusCode.OK, _codigoPostalService.GetByCodigo(codigo));
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }
    }
}