//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoBaseDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPO_PLATAFORMA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_PLATAFORMA()
        {
            this.CANLOG1 = new HashSet<CANLOG>();
            this.LOG_PLATAFORMA = new HashSet<LOG_PLATAFORMA>();
            this.PRODUCTO = new HashSet<PRODUCTO>();
            this.USUARIO_TERMINAL = new HashSet<USUARIO_TERMINAL>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> CanLog { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CANLOG> CANLOG1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOG_PLATAFORMA> LOG_PLATAFORMA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO> PRODUCTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO_TERMINAL> USUARIO_TERMINAL { get; set; }
    }
}