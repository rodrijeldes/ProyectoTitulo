using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_HojaDeTareas.Models.Inicio
{
    public class RegistreseModel
    {
        [Required]
        public string usuario { set; get; }

        [Required]
        public string clave { set; get; }

        [Required]
        public string confirmacion { set; get; }

        public string mensaje { set; get; }
    }
}