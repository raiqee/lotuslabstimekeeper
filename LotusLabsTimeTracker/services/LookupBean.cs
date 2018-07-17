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

        public IList<WorkType> getWorkTypes() {
            IList<WorkType> workTypes = getMySession().QueryOver<WorkType>().List();
            return workTypes;
        }


        //SAVES
        public WorkType saveWorkType(WorkType workType) {
            WorkType res = getMySession().Merge(workType);
            getMySession().Transaction.Commit();
            return res;
        }
    }
}
