using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_HojaDeTareas.Models.Proyecto
{
    public class ListaPrticipantesProyectoModel
    {
        public int idProyecto { set; get; }
        public List<Usp_ListaUsuarioProyecto_Result> listaUsuarios { set; get; }
    }
}