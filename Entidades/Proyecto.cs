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
    
    public partial class Proyecto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proyecto()
        {
            this.AdjuntoProyecto = new HashSet<AdjuntoProyecto>();
            this.UsuarioProyecto = new HashSet<UsuarioProyecto>();
            this.Actividad = new HashSet<Actividad>();
        }
    
        public int idProyecto { get; set; }
        public string nombreProyecto { get; set; }
        public string comentario { get; set; }
        public Nullable<int> idUsuarioPorpietario { get; set; }
        public int idEstadoProyecto { get; set; }
        public Nullable<System.DateTime> fechaCreacion { get; set; }
        public Nullable<System.DateTime> inicioEstimado { get; set; }
        public Nullable<System.DateTime> terminoEstimado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdjuntoProyecto> AdjuntoProyecto { get; set; }
        public virtual EstadoProyecto EstadoProyecto { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsuarioProyecto> UsuarioProyecto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actividad> Actividad { get; set; }
    }
}
