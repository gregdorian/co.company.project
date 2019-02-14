using co.company.Entities;
using co.Company.DataEF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace co.company.Business
{
    public class ClientesBS
    {
        private readonly FacturaConex dbCtx;

        public ClientesBS(FacturaConex db)
        {
            dbCtx = db;
        }


        public IEnumerable<Clientes> GetCliente()
        {
            return dbCtx.Clientes.ToList();
        }

        public Clientes GetClienteID(Int64 id)
        {

            return dbCtx.Clientes.Find(id);
        }

        public void CreateCliente(Clientes clientes)
        {

            dbCtx.Clientes.Add(clientes);
        }

        public  void UpdateCliente(Clientes clientes)
        {

            dbCtx.Entry(clientes).State = EntityState.Modified;
        }

         public void DeleteCliente(int studentID)
        {
            Clientes clientes = dbCtx.Clientes.Find(studentID);
            dbCtx.Clientes.Remove(clientes);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbCtx.Dispose();
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
