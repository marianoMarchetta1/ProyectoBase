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
    
    public partial class PERMISO_USUARIO
    {
        public int Id { get; set; }
        public bool Permiso { get; set; }
        public int UsuarioId { get; set; }
        public int FuncionalidadId { get; set; }
    
        public virtual FUNCIONALIDAD FUNCIONALIDAD { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
