//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infraestructure.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPO_REPORTE
    {
        public int TIPO_REPORTE_ID { get; set; }
        public string NOMBRE_REPORTE { get; set; }
        public string DESCRIPCIÓN_REPORTE { get; set; }
    
        public virtual REPORTES REPORTES { get; set; }
    }
}
