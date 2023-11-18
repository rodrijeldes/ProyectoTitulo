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
    
    public partial class Adjuntos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adjuntos()
        {
            this.AdjuntoActividad = new HashSet<AdjuntoActividad>();
            this.AdjuntoProyecto = new HashSet<AdjuntoProyecto>();
        }
    
        public int idAdjunto { get; set; }
        public Nullable<int> idUsuarioCreador { get; set; }
        public string nombreAdjunto { get; set; }
        public string tipoAdjunto { get; set; }
        public string contenType { get; set; }
        public byte[] archivo { get; set; }
        public string extension { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdjuntoActividad> AdjuntoActividad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdjuntoProyecto> AdjuntoProyecto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}