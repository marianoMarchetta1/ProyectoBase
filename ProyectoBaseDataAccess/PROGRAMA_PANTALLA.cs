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
    
    public partial class PROGRAMA_PANTALLA
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int CategoriaId { get; set; }
        public int ProgramaId { get; set; }
        public string CodigoPantalla { get; set; }
        public bool PantallaPrincipal { get; set; }
    
        public virtual CATEGORIA CATEGORIA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual PROGRAMA PROGRAMA { get; set; }
    }
}
