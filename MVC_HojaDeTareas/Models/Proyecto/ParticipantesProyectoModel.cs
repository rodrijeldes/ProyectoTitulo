using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_HojaDeTareas.Models.Proyecto
{
    public class ParticipantesProyectoModel
    {
        public int idProyecto { set; get; }
        public string usuario { set; get; }
        public bool asignaActividad { set; get; }
        public bool cierraActicidad { set; get; }
        public bool agregaParticipante { set; get; }

    }
}