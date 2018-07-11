using LotusLabsTimeTracker.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace LotusLabsTimeTracker.services
{
    class ModuleBean : HibernateSessionFactory
    {
        public ModuleBean() {
            this.getMySession().BeginTransaction();
        }

        public IList<Module> GetModuleList() {
            ICriteria criteria = getMySession().CreateCriteria<Module>();
            IList<Module> list = criteria.List<Module>();
            getMySession().Transaction.Commit();
            return list;
        }
    }
}
