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
        public decimal Precio { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public short Cantidad { get; set; }
    
        public virtual FacturaEncabezado FacturaEncabezado { get; set; }
        public virtual Productos Productos { get; set; }

        //protected FacturaDetalle()
        //{

        //}

        public FacturaDetalle(int idProducto, string codigoProducto, string descripcionProducto, decimal precio, decimal descuento, short cantidad = 1)
        {
            //if (Cantidad <= 0)
            //{
            //    throw new OrderingDomainException("Invalid number of units");
            //}

            //if ((unitPrice * units) < discount)
            //{
            //    throw new OrderingDomainException("The total of order item is lower than applied discount");
            //}

            IdProducto = idProducto;
            CodigoProducto = codigoProducto;
            DescripcionProducto = descripcionProducto;
            Precio = precio;
            Descuento = descuento;
            Cantidad = cantidad;
     
        }

        //public decimal GetCurrentDiscount()
        //{
        //    return _descuento;
        //}

        public void AddUnits(short units)
        {
            if (units < 0)
            {
                //throw new OrderingDomainException("Invalid units");
                throw new Exception();
            }

            Cantidad += units;
        }

        public short? GetUnits()
        {
            return Cantidad;
        }

        public decimal GetUnitPrice()
        {
            return Precio;
        }
    }
}
