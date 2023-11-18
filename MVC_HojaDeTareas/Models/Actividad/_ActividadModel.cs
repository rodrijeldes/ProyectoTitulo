using DTO;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_HojaDeTareas.Models.Actividad
{
    public class _ActividadModel
    {
        public int idProyecto { set; get; }
        public List<ListaDTO> listaProyectos { set; get; }
        [Required]
        public string nombreActividad { set; get; }
        public string descripcion { set; get; }

        public DateTime? fechaInicio { set; get; }
        public DateTime? fechaTermino { set; get; }
        public UsuarioProyecto usuarioProyeto { set; get; }
    }
}