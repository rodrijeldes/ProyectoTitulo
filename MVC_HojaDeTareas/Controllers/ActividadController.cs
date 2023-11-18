using Entidades;
using MVC_HojaDeTareas.Models.Actividad;
using Negocio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_HojaDeTareas.Controllers
{
    public class ActividadController : BaseController
    {
        private ActividadNegocio acn = new ActividadNegocio();
        // GET: Actividad
        public ActionResult Actividad(int? idProyecto = 0)
        {
            ProyectoNegocio negocioProyecto = new ProyectoNegocio();

            ActividadModel model = new ActividadModel();
            model.idListaProyecto = idProyecto ?? 0;
            model.listaProyectos = negocioProyecto.ListaProyectosPorUsuario(getIdUsuario());
            return View(model);
        }
        [HttpPost]
        public ActionResult Actividad(_ActividadModel model)
        {
            ProyectoNegocio negocioProyecto = new ProyectoNegocio();
            Actividad a = new Actividad();
            a.idUsuario = getIdUsuario();
            a.idEstadoActual = Convert.ToInt32(ConfigurationManager.AppSettings["Actividad_CREADA"].ToString());
            a.idProyecto = model.idProyecto;
            a.nombre = model.nombreActividad;
            a.descripcion = model.descripcion;
            a.fechaInicio = model.fechaInicio;
            a.fechaTerminoPropuesto = model.fechaTermino;
            acn.CrearActividad(a);


            model.idProyecto = model.idProyecto ;
            model.listaProyectos = negocioProyecto.ListaProyectosPorUsuario(getIdUsuario());
            return RedirectToAction("Actividad",new { idProyecto = model.idProyecto });
        }

        public ActionResult _Actividad(int? idProyecto)
        {

            ProyectoNegocio negocioProyecto = new ProyectoNegocio();

            _ActividadModel model = new _ActividadModel();
            model.idProyecto = idProyecto ?? 0;
           

            return PartialView(model);
        }
        public ActionResult _ListaActividades(int? idProyecto=0)
        {
            ListaActividadesModel model = new ListaActividadesModel();
            ProyectoNegocio proyectoNegocio = new ProyectoNegocio();
            model.usuarioProyeto = proyectoNegocio.BuscarUsuarioProyectoPorIdUsuario(getIdUsuario());
            model.listaActividades = acn.ListarActividadPorIdUsuarioIdProyecto(getIdUsuario(), idProyecto??0);
            return PartialView(model);
        }
    }
}
