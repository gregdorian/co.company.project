using co.company.Entities;
using co.Company.DataEF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.company.Business
{
    public class ProductoBS
    {

        private readonly FacturaConex db;

        public ProductoBS(FacturaConex _db)
        {
            db = _db;
                
        }

        public IEnumerable<Productos> GetProducto()
        {

            return db.Productos.ToList();
        }

        public Productos GetProductoID(Int64 id)
        {
            return db.Productos.Find(id);
        }

        public void CreateProducto(Productos productos)
        {

            db.Productos.Add(productos);
        }

        public void UpdateProducto(Productos productos)
        {
            db.Entry(productos).State = EntityState.Modified;
        }

        public  void DeleteProducto(Int64 productID)
        {

            Productos productos = db.Productos.Find(productID);
            db.Productos.Remove(productos);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
