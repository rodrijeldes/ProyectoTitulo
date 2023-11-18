using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_HojaDeTareas.Models
{
    public class LoginModel
    {

        [Required(ErrorMessage = "El usuario es requerido")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "El usuario tiene mín. 5 y máx. 30 caracteres")]
        public string usuario { set; get; }
        [Required(ErrorMessage = "La contraseña es requerida")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "la contraseña tiene mín. 5 y máx. 15 caracteres")]
        public string clave { set; get; }

        public string mensaje { set; get; }
    }
}