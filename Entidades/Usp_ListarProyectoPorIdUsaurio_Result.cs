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
    
    public partial class Usp_ListarProyectoPorIdUsaurio_Result
    {
        public int idEstadoProyecto { get; set; }
        public string nombreProyecto { get; set; }
        public string comentario { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public string nombreEstado { get; set; }
        public string TipoIntegrante { get; set; }
        public Nullable<System.DateTime> inicioEstimado { get; set; }
        public Nullable<System.DateTime> terminoEstimado { get; set; }
        public int idProyecto { get; set; }
        public Nullable<bool> puedeAgregarParticipante { get; set; }
    }
}
