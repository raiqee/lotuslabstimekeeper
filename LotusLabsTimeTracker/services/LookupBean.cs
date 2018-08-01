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

        public IList<UserType> getUserTypes(Boolean isActiveOnly)
        {
            if (isActiveOnly) {
                return getMySession().QueryOver<UserType>()
                    .Where(x => x.activeFlag == isActiveOnly)
                    .List();
            }
            return getMySession().QueryOver<UserType>().List();
        }

        public IList<WorkType> getWorkTypes(Boolean isActiveOnly)
        {
            if (isActiveOnly) {
                return getMySession().QueryOver<WorkType>()
                    .Where(x => x.activeFlag == isActiveOnly)
                    .List();
            }
            return getMySession().QueryOver<WorkType>().List();
        }

        public IList<TaskType> getTaskTypes(Boolean isActiveOnly)
        {
            if (isActiveOnly){
                return getMySession().QueryOver<TaskType>()
                    .Where(x => x.activeFlag == isActiveOnly)
                    .List();
            }
            return getMySession().QueryOver<TaskType>().List();
        }

        public IList<Project> getProjects(Boolean isActiveOnly)
        {
            if (isActiveOnly){
                return getMySession().QueryOver<Project>()
                    .Where(x => x.activeFlag == isActiveOnly)
                    .List();
            }
            return getMySession().QueryOver<Project>().List();
        }

        public IList<Project> getProjectsByWorkType(Boolean isActiveOnly, WorkType workType)
        {
            if (isActiveOnly)
            {
                return getMySession().QueryOver<Project>()
                    .Where(x => x.activeFlag == isActiveOnly && x.workType.id == workType.id)
                    .List();
            }
            return getMySession().QueryOver<Project>()
                .Where(x => x.workType.id == workType.id)
                .List();
        }

        public WorkType getWorkType(String id)
        {
            return getMySession().QueryOver<WorkType>()
                .Where(x => x.id == Int64.Parse(id))
                .SingleOrDefault();
        }

        public Project getProject(String id)
        {
            return getMySession().QueryOver<Project>()
                .Where(x => x.id == Int64.Parse(id))
                .SingleOrDefault();
        }

        public TaskType getTaskType(String id)
        {
            return getMySession().QueryOver<TaskType>()
                .Where(x => x.id == Int64.Parse(id))
                .SingleOrDefault();
        }

        public bool isWorkTypeExistByCode(String code, long id) {
            bool isExist = false;
            WorkType workType = getMySession().Query<WorkType>().Where(x => x.code.ToLower() == code.ToLower() && x.id != id).SingleOrDefault();
            if (workType!=null&&workType.id != 0)
            {
                isExist = true;
            }
            return isExist;
        }

        public bool isProjectExistByCode(String code, long id)
        {
            bool isExist = false;
            Project project = getMySession().Query<Project>().Where(x => x.code.ToLower() == code.ToLower() && x.id != id).SingleOrDefault();
            if (project != null && project.id != 0)
            {
                isExist = true;
            }
            return isExist;
        }

        public bool isTaskTypeExistByCode(String code, long id)
        {
            bool isExist = false;
            TaskType taskType = getMySession().Query<TaskType>().Where(x => x.code.ToLower() == code.ToLower() && x.id != id).SingleOrDefault();
            if (taskType != null && taskType.id != 0)
            {
                isExist = true;
            }
            return isExist;
        }

        public WorkType saveWorkType(WorkType workType) {
            WorkType res = getMySession().Merge(workType);
            getMySession().Transaction.Commit();
            return res;
        }

        public Project saveProject(Project project)
        {
            Project res = getMySession().Merge(project);
            getMySession().Transaction.Commit();
            return res;
        }

        public TaskType saveTaskType(TaskType taskType) {
            TaskType res = getMySession().Merge(taskType);
            getMySession().Transaction.Commit();
            return res;
        }

        public void deleteWorkType(String id) {
            WorkType workType = getWorkType(id);
            getMySession().Delete(workType);
            getMySession().Transaction.Commit();
        }

        public void deleteProject(String id)
        {
            Project workType = getProject(id);
            getMySession().Delete(workType);
            getMySession().Transaction.Commit();
        }

        public void deleteTaskType(String id) {
            TaskType taskType = getTaskType(id);
            getMySession().Delete(taskType);
            getMySession().Transaction.Commit();
        }
    }
}
