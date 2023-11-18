using DTO;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_HojaDeTareas.Models.Actividad
{
    public class ActividadModel
    {
        public int idListaProyecto { set; get; }
        public List<ListaDTO> listaProyectos { set; get; }
        
    }
}