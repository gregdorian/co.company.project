﻿using co.Company.DataEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.company.Business
{
    public class AuthenticateUser
    {
        private readonly FacturaConex dbCtx;

        public AuthenticateUser(FacturaConex db)
        {
            dbCtx = db;
        }


        public static bool IngresoApp(string user, string pass)
        {

            using (FacturaConex db = new FacturaConex())
            {
                var logUser = (from u in db.Usuario
                               where u.NombreUsuario == user && u.Clave == pass
                               select u).FirstOrDefault();
                if (logUser == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
    }
}
