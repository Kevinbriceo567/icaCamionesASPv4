//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace icaCamionesASPv4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Conductor
    {
        public int idConductor { get; set; }
        public string RUN { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public Nullable<System.DateTime> fNacimiento { get; set; }
        public string Direccion { get; set; }
        public Nullable<int> idComuna { get; set; }
        public Nullable<int> Telefono { get; set; }
        public string email { get; set; }
        public string usuario { get; set; }
        public string host { get; set; }
    }
}
