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
    
    public partial class PERFIL_PRODUCTO
    {
        public int Id { get; set; }
        public int PerfilId { get; set; }
        public int ProductoId { get; set; }
    
        public virtual PERFIL PERFIL { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
