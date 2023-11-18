using Entidades;
using MVC_HojaDeTareas.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace MVC_HojaDeTareas.Controllers
{
    public class BaseController : Controller
    {

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            
            if (Session["UsuarioBS"] == null)
            {
                filterContext.Result = this.RedirectToAction("Login", "Inicio");
            }
            var direct = Request.Url.AbsolutePath;
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["UsuarioBS"] == null)
            {
                filterContext.Result = this.RedirectToAction("Login", "Inicio");
            }
        }
        protected override void OnException(ExceptionContext filterContext)
        {
            if (Session["UsuarioBS"] == null)
            {
                filterContext.Result = this.RedirectToAction("Login", "Inicio");
            }
        }

        protected int getIdUsuario()
        {
            Usuario usuario = (Usuario)Session["UsuarioBS"];
            if (usuario == null)
            {
                if (CurrentUser.IdUsuario != null)
                {
                   // usuario = new Usuario(CurrentUser.IdUsuario ?? 0, CurrentUser.FullName);

                    Session["Usuario"] = usuario;
                }
                else
                {
                    usuario = new Usuario();
                }
            }
            int idUsuario = usuario.idUsuario ;
            return idUsuario;
        }


      
    }
}