using co.company.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.company.Business
{
   public class FacturaBS
    {
        public int FacturaID { get; set; }

        private int? IdCliente;
        
        public string NumeroFactura { get; set; }
        public string CodigoEmpresa { get; set; }
        public string CodigoCliente { get; set; }
        public Nullable<float> sub_total { get; set; }
        public Nullable<float> impuesto { get; set; }
        public Nullable<float> Total { get; set; }
        public Nullable<System.DateTime> fechaFactura { get; set; }


        //Propiedades de navegacion
        //public virtual Clientes Cliente { get; private set; }

        public int? GetIdCliente
        {
            get
            {
                return IdCliente;
            }
        }

 

        private readonly List<FacturaDetalle> _facturaDetalle;
        public IReadOnlyCollection<FacturaDetalle> facturaDetalle => _facturaDetalle;

        protected FacturaBS()
        {
            _facturaDetalle = new List<FacturaDetalle>();
        }

        public void AddFacturaDetalle(int IdProducto, string CodigoProducto, string DescripcionProducto, decimal Precio, decimal Descuento, short Cantidad = 1)
        {
            var existingDetalleForProduct = _facturaDetalle.Where(o => o.IdProducto == IdProducto)
                .SingleOrDefault();

            if (existingDetalleForProduct != null)
            {
                //if previous line exist modify it with higher discount  and units..

                //if (Descuento > existingDetalleForProduct.GetCurrentDiscount())
                //{
                //    existingDetalleForProduct.SetNewDiscount(discount);
                //}

                //existingOrderForProduct.AddUnits(units);
                throw new Exception();
            }
            else
            {
                //add validated new order item

                var orderItem = new FacturaDetalle(IdProducto, CodigoProducto, DescripcionProducto, Precio, Descuento, Cantidad);
                _facturaDetalle.Add(orderItem);
            }
        }

        public decimal GetTotal()
        {
            //return _facturaDetalle.Sum(o => o.GetUnits() * o.GetUnitPrice());
            return _facturaDetalle.Sum(o =>  o.Cantidad * o.Precio);
        }
    }
}
