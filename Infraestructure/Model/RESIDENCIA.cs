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
    
    public partial class RESIDENCIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESIDENCIA()
        {
            this.GESTION_PLANES_COBRO = new HashSet<GESTION_PLANES_COBRO>();
        }
    
        public int ID_RESIDENCIA { get; set; }
        public int ID_ESTADO_RESIDENCIA { get; set; }
        public int NUMERO_RESIDENCIA { get; set; }
        public int CANTIDAD_PERSONAS { get; set; }
        public System.DateTime ANIO_INICIO { get; set; }
        public int CANTIDAD_CARROS { get; set; }
        public int ID_USUARIO { get; set; }
    
        public virtual ESTADO_RESIDENCIA ESTADO_RESIDENCIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GESTION_PLANES_COBRO> GESTION_PLANES_COBRO { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
