using LotusLabsTimeTracker.model;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusLabsTimeTracker.services
{
    class ProductionBean : HibernateSessionFactory
    {
        public ProductionBean()
        {
            this.getMySession().BeginTransaction();
        }

        public IList<UserTask> getUserTasks(Users user, WorkType workType, Project project, TaskType taskType,
            DateTime start, DateTime end) {
            ICriteria criteria = getMySession().CreateCriteria<UserTask>();

            if (user != null && user.id != 0) {
                criteria.Add(Restrictions.Eq(Projections.Property<UserTask>(x => x.user.id), user.id));
            }

            if (workType != null && workType.id != 0) {
                criteria.Add(Restrictions.Eq(Projections.Property<UserTask>(x => x.workType.id), workType.id));
            }

            if (project != null && project.id != 0) {
                criteria.Add(Restrictions.Eq(Projections.Property<UserTask>(x => x.project.id), project.id));
            }

            if (taskType != null && taskType.id != 0) {
                criteria.Add(Restrictions.Eq(Projections.Property<UserTask>(x => x.taskType.id), taskType.id));
            }

            if (start != null) {
                criteria.Add(Restrictions.Ge(Projections.Property<UserTask>(x => x.startDateTime),start));
                criteria.Add(Restrictions.Le(Projections.Property<UserTask>(x => x.startDateTime), end));
            }


            return criteria.List<UserTask>();
        }
    }
}
