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
    
    public partial class FacturaDetalle
    {
        public int IdFacturaDetalle { get; set; }
        public Nullable<int> IdFacturaEncabezado { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public string NumeroFactura { get; set; }
        public string CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public Nullable<float> Descuento { get; set; }
        public Nullable<short> Cantidad { get; set; }
    
        public virtual FacturaEncabezado FacturaEncabezado { get; set; }
        public virtual Productos Productos { get; set; }

        //protected FacturaDetalle()
        //{

        //}

        public FacturaDetalle(int IdProducto, string CodigoProducto, string DescripcionProducto, decimal PrecioUnitario, decimal Descuento, int Cantidad = 1)
        {

        }
    }
}
