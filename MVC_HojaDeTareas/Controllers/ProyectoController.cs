using Entidades;
using MVC_HojaDeTareas.Models;
using MVC_HojaDeTareas.Models.Proyecto;
using Negocio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_HojaDeTareas.Controllers
{
    public class ProyectoController : BaseController
    {

        private ProyectoNegocio proyectoNegocio = new ProyectoNegocio();

        public ActionResult Proyecto()
        {
            ProyectoModel model = new ProyectoModel();

            return View(model);
        }
        [HttpPost]
        public ActionResult Proyecto(ProyectoModel model)
        {
            Proyecto p = new Proyecto();
            p.fechaCreacion = DateTime.Now;
            p.idEstadoProyecto = Convert.ToInt32(ConfigurationManager.AppSettings["idEstadoCreado"].ToString());
            p.idUsuarioPorpietario = getIdUsuario();
            p.nombreProyecto = model.nombreProyecto;
            p.comentario = model.comentarioProyecto;
            p.inicioEstimado = model.inicioPlaneado;
            p.terminoEstimado = model.terminoPlaneado;
            var result = proyectoNegocio.CrearProyecto(p);
            if (result.Error)
            { return View(model); }
            else
            {
                ProyectoModel model2 = new ProyectoModel();
                return View(model2);
            }
        }

        public ActionResult _ListaProyectos()
        {

            _ListaProyectoModel model = new _ListaProyectoModel();
            model.proyectos = proyectoNegocio.ListarProyectosPorUsuario(getIdUsuario()) ?? new List<Usp_ListarProyectoPorIdUsaurio_Result>(); 
            return PartialView(model);
    
        }

        public ActionResult _ParticipantesDelProyecto(int idProyecto)
        {
            ParticipantesProyectoModel model = new ParticipantesProyectoModel();
            model.idProyecto = idProyecto;
            return PartialView(model);
        }

        public ActionResult _ListaParticipantesDelProyecto(int idProyecto)
        {
            ListaPrticipantesProyectoModel model = new ListaPrticipantesProyectoModel();
            model.listaUsuarios = proyectoNegocio.ListaUsuariosProyectos(idProyecto);

            return PartialView(model);
        }

        public ActionResult _ResultadoBusquedaUsuarios(string usuario)
        {
            ResultadoBusquedaUsuariosModel model = new ResultadoBusquedaUsuariosModel();
            model.listaUsuarios = proyectoNegocio.FiltrarUsuariosPorNombre(usuario);
            return PartialView(model);
        }

        public JsonResult AgregarUsuarioProyecto(int idUsuario, int idProyecto, bool asigna, bool cierra, bool participantes)
        {
            proyectoNegocio.AgregarUsuarioProyecto(idUsuario, idProyecto, asigna, cierra, participantes);

            ListaPrticipantesProyectoModel model = new ListaPrticipantesProyectoModel();
            model.listaUsuarios = proyectoNegocio.ListaUsuariosProyectos(idProyecto);
            var salida = new { Succes =true };

            return Json(salida);
        }


    }

}