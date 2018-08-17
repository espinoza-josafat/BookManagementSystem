using BookManagementSystem.Tools.Exceptions;
using BookManagementSystem.Business.Process;
using BookManagementSystem.Domain.Services;
using BookManagementSystem.Web.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Security;

namespace BookManagementSystem.Web.Controllers.RESTful
{
    public class AccountController : ApiController
    {
        IUsuarioService _usuarioService;

        public AccountController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public HttpResponseMessage Login(UserLoginModel modelo)
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                if (modelo == null)
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El modelo no puede ser nulo" });
                if (string.IsNullOrWhiteSpace(modelo.UserName))
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "El usuario no puede ser nulo o vacío" });
                if (string.IsNullOrWhiteSpace(modelo.Password))
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { message = "La contraseña no puede ser nula o vacía" });
                
                var usuario = (new ProcesoAutenticarUsuario()).Ejecutar(modelo.UserName, modelo.Password);

                IPrincipal principalObj = (new Providers.PrincipalProvider()).CreatePrincipal(usuario.Username);
                Thread.CurrentPrincipal = principalObj;
                HttpContext.Current.User = principalObj;
                HttpContext.Current.Session["UserName"] = usuario.NombreCompleto;
                HttpContext.Current.Session["User"] = usuario;

                FormsAuthentication.SetAuthCookie(usuario.Username, false);
                
                resultado = Request.CreateResponse(HttpStatusCode.OK, 1);
            }
            catch (BusinessLogicException businessLogicException)
            {
                resultado = Request.CreateResponse(HttpStatusCode.NotFound, new { message = businessLogicException.Message });
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }

        [HttpPost]
        public HttpResponseMessage Logoff()
        {
            var resultado = (HttpResponseMessage)null;

            try
            {
                HttpContext.Current.Session.Clear();
                HttpContext.Current.Session.Abandon();

                HttpContext.Current.User = null;

                Thread.CurrentPrincipal = null;


                FormsAuthentication.SignOut();

                resultado = Request.CreateResponse(HttpStatusCode.OK, 1);
            }
            catch (Exception exception)
            {
                resultado = Request.CreateResponse(HttpStatusCode.InternalServerError, new { message = exception.Message });
            }

            return resultado;
        }
    }
}