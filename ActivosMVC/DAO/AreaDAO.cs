using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActivosMvc.Modelo;
using ActivosMvc.Utils;
using NHibernate;

namespace ActivosMvc.DAO
{
    public class AreaDAO
    {
        private static AreaDAO instance = null;
        ISession session = NHConnection.Session;

        private AreaDAO() { }

        public static AreaDAO getInstance()
        {
            if (instance == null)
                instance = new AreaDAO();
            return instance;
        }

        public List<Area> getListDirecciones(int nivelArea)
        {
            List<Area> areas = new List<Area>();
            var list = session.CreateQuery("From Area a Where a.NivelArea = " + nivelArea + "").List<Area>();
            foreach (Area a in list)
                areas.Add(a);

            return areas;
        }
    }
}