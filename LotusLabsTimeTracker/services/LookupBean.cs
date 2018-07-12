using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotusLabsTimeTracker.model;

namespace LotusLabsTimeTracker.services
{
    class LookupBean : HibernateSessionFactory
    {
        public LookupBean() {
            this.getMySession().BeginTransaction();
        }

        public IList<UserType> getUserTypes() {
            IList<UserType> userTypes = getMySession().QueryOver<UserType>().List();
            return userTypes;
        }
    }
}
