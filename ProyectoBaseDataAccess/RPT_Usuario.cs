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
    
    public partial class RPT_Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Nombre { get; set; }
        public string Codigo_Persona { get; set; }
        public string Email { get; set; }
        public Nullable<int> Dias_Vigencia_Clave { get; set; }
        public string Login_NT { get; set; }
        public bool Bloqueado { get; set; }
        public bool Bloqueado_Inactividad { get; set; }
        public string Clave { get; set; }
        public Nullable<bool> Cambio_Clave { get; set; }
        public Nullable<int> Cant_Cambios_Clave { get; set; }
        public Nullable<System.DateTime> Ultimo_Cambio_Clave { get; set; }
        public bool Activo { get; set; }
        public Nullable<int> NumeroDocumento { get; set; }
        public Nullable<int> TipoDocumentoId { get; set; }
        public string BloqueadoPor { get; set; }
        public Nullable<System.DateTime> FechaBloqueo { get; set; }
        public string MotivoBloqueo { get; set; }
        public string EliminadoPor { get; set; }
        public Nullable<System.DateTime> FechaEliminado { get; set; }
        public Nullable<int> SectorId { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
    }
}
