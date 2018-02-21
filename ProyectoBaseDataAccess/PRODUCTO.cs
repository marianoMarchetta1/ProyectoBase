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
    
    public partial class PRODUCTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTO()
        {
            this.FUNCIONALIDAD = new HashSet<FUNCIONALIDAD>();
            this.MODO_EXCLUSIVO = new HashSet<MODO_EXCLUSIVO>();
            this.PERFIL_PRODUCTO = new HashSet<PERFIL_PRODUCTO>();
            this.PRODUCTO_CATEGORIA = new HashSet<PRODUCTO_CATEGORIA>();
            this.PROGRAMA_PANTALLA = new HashSet<PROGRAMA_PANTALLA>();
        }
    
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Base_Path { get; set; }
        public string Rama { get; set; }
        public Nullable<int> TipoPlataformaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FUNCIONALIDAD> FUNCIONALIDAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MODO_EXCLUSIVO> MODO_EXCLUSIVO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFIL_PRODUCTO> PERFIL_PRODUCTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCTO_CATEGORIA> PRODUCTO_CATEGORIA { get; set; }
        public virtual TIPO_PLATAFORMA TIPO_PLATAFORMA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROGRAMA_PANTALLA> PROGRAMA_PANTALLA { get; set; }
    }
}
