using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActivosMvc.Utils;
using ActivosMvc.Modelo;
using log4net.Repository.Hierarchy;
using NHibernate;

namespace ActivosMvc.DAO
{
    public class ActivoDAO : GenericDAO<Activo>
    {
        private static ActivoDAO instance = null;
        ISession session = NHConnection.Session;

        private ActivoDAO() { }

        public static ActivoDAO getInstance()
        {
            if (instance == null)
                instance = new ActivoDAO();
            return instance;
        }

        public bool saveOrUpdate(Activo activo)
        {
            try
            {
                base.saveOrUpdate(activo);
                return true;
            }
            catch(Exception ex)
            {
                
            }
            return false;
        }

        public Activo get(int id)
        {
            return base.get(id);
        }

        public List<Activo> getListActivosPorAlmacen()
        {
            List<Activo> activos = new List<Activo>();
            var list = session.CreateQuery("From Activo a Where a.Almacen.Id=3").List<Activo>();
            foreach (Activo a in list)
                activos.Add(a);

            return activos;
        }

    }
}