using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_HojaDeTareas.Models
{
    public class _ListaProyectoModel
    {
        public int idUsuario { set; get; }
        public List<Usp_ListarProyectoPorIdUsaurio_Result> proyectos { set; get; }
    }
}