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

        public UserTask getUserTask(long id)
        {
            return getMySession().QueryOver<UserTask>()
                .Where(x => x.id == id)
                .SingleOrDefault();
        }

        public void deleteUserTask(long id)
        {
            UserTask userTask = getUserTask(id);
            getMySession().Delete(userTask);
            getMySession().Transaction.Commit();
        }
    }
}
