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
    
    public partial class Usp_ListaUsuarioProyecto_Result
    {
        public int idUsuario { get; set; }
        public string correo { get; set; }
        public string tipoIntegrante { get; set; }
        public Nullable<bool> puedeAgregarParticipante { get; set; }
        public Nullable<bool> puedeAsignarActividad { get; set; }
        public Nullable<bool> puedeCerrarActividad { get; set; }
    }
}