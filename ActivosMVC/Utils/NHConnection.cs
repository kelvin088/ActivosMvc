﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace ActivosMvc.Utils
{
    public sealed class NHConnection
    {
        private static ISessionFactory sessionFactory;
        private static Configuration nhConfiguration;
        private static ISession session;

        public static ISession Session
        {
            get
            {
                if (session == null)
                    GetCurrentSession();
                return session;
            }
        }

        private static void Init()
        {
            nhConfiguration = new Configuration();
            //nhConfiguration.Configure("NhibernateUtils/NHibernate.cfg.xml");
            nhConfiguration.AddAssembly("ActivosMvc");
            sessionFactory = nhConfiguration.BuildSessionFactory();
        }

        private static ISessionFactory GetSessionFactory()
        {
            if(sessionFactory == null)
                Init();
            return sessionFactory;
        }

        private static void GetCurrentSession()
        {
            session = GetSessionFactory().OpenSession();
        }
    }
}