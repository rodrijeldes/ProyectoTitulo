//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsuarioProyecto
    {
        public int idUsuarioProyecto { get; set; }
        public int idUsuario { get; set; }
        public int idProyecto { get; set; }
        public Nullable<bool> esPropietario { get; set; }
        public Nullable<bool> puedeAsignarActividad { get; set; }
        public Nullable<bool> puedeCerrarActividad { get; set; }
        public Nullable<bool> puedeAgregarParticipante { get; set; }
        public Nullable<bool> activo { get; set; }
    
        public virtual Proyecto Proyecto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
