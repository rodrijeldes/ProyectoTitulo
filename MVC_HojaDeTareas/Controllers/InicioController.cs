using DTO;
using Entidades;
using MVC_HojaDeTareas.Helper;
using MVC_HojaDeTareas.Models;
using MVC_HojaDeTareas.Models.Inicio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace MVC_HojaDeTareas.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        LoginNegocio ln = new LoginNegocio();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            LoginModel model = new LoginModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {

            Usuario usuario = ln.Logear(model.usuario, model.clave);
            if (usuario != null)
            {
                SetCustomAuthenticationCookie(usuario);
                Session["UsuarioBS"] = usuario;
                return RedirectToAction("Dashboard", "Dashboard");
            }
            else
            {
                model.mensaje = "Usuario o clave inválido";
                return View(model);
            }
            
            
        }

        public ActionResult Logout()
        {
            Session["UsuarioBS"] = null;

            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Inicio");
        }

        public ActionResult Registrese()
        {
            RegistreseModel model = new RegistreseModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Registrese(RegistreseModel model)
        {
            ResultadoDTO resultado = ln.RegistrarUsuario(model.usuario, model.clave, model.confirmacion);
            if (resultado.Error)
            {
                model.mensaje = resultado.Mensaje;
                return View(model);
            }
            else
            {
                LoginModel lm = new LoginModel();
                lm.usuario = model.usuario;
                lm.clave = model.clave;
                return RedirectToAction("Login", "Inicio", lm);
            }




        }



        void SetCustomAuthenticationCookie(Usuario sesion)
        {
            var principalModel = new CustomPrincipalModel();
            principalModel.FullName = sesion.nombreUsuario;
            principalModel.IdUsuario = sesion.idUsuario;

            FormsAuthentication.SetAuthCookie(principalModel.IdUsuario.ToString(), true);
            var serializer = new JavaScriptSerializer();
            string userData = serializer.Serialize(principalModel);
            var authCookie = FormsAuthentication.GetAuthCookie(principalModel.FullName, true);
            var ticket = FormsAuthentication.Decrypt(authCookie.Value);
            var newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, ticket.IssueDate, ticket.Expiration, ticket.IsPersistent, userData);
            authCookie.Value = FormsAuthentication.Encrypt(newTicket);
            Response.Cookies.Add(authCookie);
        }
    }
}