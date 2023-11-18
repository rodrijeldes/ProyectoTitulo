using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_HojaDeTareas.Models
{
    public class ProyectoModel
    {
        public int idProyecto { set; get; }
        public string nombreProyecto { set; get; }
        public string comentarioProyecto { set; get; }
        public DateTime? inicioPlaneado { set; get; }
        public DateTime? terminoPlaneado { set; get; }
    }
}