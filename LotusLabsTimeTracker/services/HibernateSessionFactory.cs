using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using NHibernate;
using NHibernate.Cfg;

namespace LotusLabsTimeTracker.services
{
    public class HibernateSessionFactory
    {

        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;

        public HibernateSessionFactory()
        {
            myConfiguration = new Configuration().Configure()
                .AddFile("models/Module.hbm.xml") 
                .AddFile("models/Usertype.hbm.xml")
                .AddFile("models/Users.hbm.xml");
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();
        }

        public ISession getMySession() {
            return this.mySession;
        }

    }
}

