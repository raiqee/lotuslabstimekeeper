using LotusLabsTimeTracker.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusLabsTimeTracker.services
{
    class UserTaskBean : HibernateSessionFactory
    {
        public UserTaskBean()
        {
            this.getMySession().BeginTransaction();
        }

        public UserTask saveUserTask(UserTask userTask)
        {
            UserTask res = getMySession().Merge(userTask);
            getMySession().Transaction.Commit();
            return res;
        }
    }
}
