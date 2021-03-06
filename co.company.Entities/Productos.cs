//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace co.company.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.FacturaDetalle = new HashSet<FacturaDetalle>();
        }
    
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public Nullable<float> precio { get; set; }
        public Nullable<float> precioCosto { get; set; }
        public Nullable<short> stock { get; set; }
        public Nullable<short> stockMinimo { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaDetalle> FacturaDetalle { get; set; }
    }
}
