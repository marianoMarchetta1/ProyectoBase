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
    
    public partial class CONF_PASSWORD_SESION
    {
        public int Id { get; set; }
        public Nullable<bool> Alfabetica { get; set; }
        public Nullable<bool> Numerica { get; set; }
        public Nullable<bool> CaracteresEspeciales { get; set; }
        public Nullable<bool> PermiteNrosConsecutivos { get; set; }
        public Nullable<bool> PermiteLetrasConsecutivas { get; set; }
        public Nullable<bool> PermiteRepetirPosicion { get; set; }
        public Nullable<bool> PermiteCaracteresIguales { get; set; }
        public Nullable<bool> CaseSensitive { get; set; }
        public Nullable<int> CaracteresMinimos { get; set; }
        public Nullable<int> CantidadRepeticiones { get; set; }
        public Nullable<int> MaxDiasInactividad { get; set; }
        public Nullable<int> MaxDiasCaducidad { get; set; }
        public Nullable<int> MinutosPermitidosInactividad { get; set; }
        public Nullable<int> CantIntentosFallidos { get; set; }
    }
}