using LotusLabsTimeTracker.model;
using LotusLabsTimeTracker.services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotusLabsTimeTracker.controllers
{
    class LookupController
    {
        public List<String> validateWorkType(WorkType workType)
        {
            List<String> errMessages = new List<string>();
            if (String.IsNullOrEmpty(workType.code))
            {
                errMessages.Add("Work Type Code is required");
            }

            if (String.IsNullOrEmpty(workType.name))
            {
                errMessages.Add("Work Type Name is required");
            }
            return errMessages;
        }

        public List<String> validateProject(Project project)
        {
            List<String> errMessages = new List<string>();
            if (String.IsNullOrEmpty(project.code))
            {
                errMessages.Add("Project Code is required");
            }

            if (String.IsNullOrEmpty(project.name))
            {
                errMessages.Add("Project Name is required");
            }
            
            if (project.workType.id == 0)
            {
                errMessages.Add("Work Type is required");
            }
            return errMessages;
        }

        public List<String> validateTaskType(TaskType taskType)
        {
            List<String> errMessages = new List<string>();
            if (String.IsNullOrEmpty(taskType.code))
            {
                errMessages.Add("Task Type Name is required");
            }

            if (String.IsNullOrEmpty(taskType.name))
            {
                errMessages.Add("Task Type Code is required");
            }
            return errMessages;
        }

        public WorkType saveWorkType(WorkType workType, Boolean isNew, Users user)
        {
            if (isNew) {
                workType.createdBy = user.id;
                workType.createdDate = DateTime.Now;
            }
            workType.updatedBy = user.id;
            workType.updatedDate = DateTime.Now;
            return getLookupBean().saveWorkType(workType);
        }

        public Project saveProject(Project project, Boolean isNew, Users user)
        {
            if (isNew) {
                project.createdBy = user.id;
                project.createdDate = DateTime.Now;
            }
            project.updatedBy = user.id;
            project.updatedDate = DateTime.Now;
            return getLookupBean().saveProject(project);
        }

        public TaskType saveTaskType(TaskType taskType, Boolean isNew, Users user)
        {
            if (isNew) {
                taskType.createdBy = user.id;
                taskType.createdDate = DateTime.Now;
            }
            taskType.updatedBy = user.id;
            taskType.updatedDate = DateTime.Now;
            return getLookupBean().saveTaskType(taskType);
        }

        public void deleteWorkType(String id) {
            getLookupBean().deleteWorkType(id);
        }

        public IList<WorkType> getWorkTypes(Boolean isActiveOnly) {
            return getLookupBean().getWorkTypes(isActiveOnly);
        }

        public WorkType getWorkType(String id) {
            return getLookupBean().getWorkType(id);
        }

        public IList<Project> getProjects(Boolean isActiveOnly)
        {
            return getLookupBean().getProjects(isActiveOnly);
        }

        public IList<Project> getProjectsByWorkType(Boolean isActiveOnly, WorkType workType)
        {
            return getLookupBean().getProjectsByWorkType(isActiveOnly, workType);
        }

        public Project getProject(String id)
        {
            return getLookupBean().getProject(id);
        }

        public IList<TaskType> getTaskTypes(Boolean isActiveOnly)
        {
            return getLookupBean().getTaskTypes(isActiveOnly);
        }

        public TaskType getTaskType(String id)
        {
            return getLookupBean().getTaskType(id);
        }

        public DataTable getWorkTypeDataTable() {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Code");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Is Active?");
            
            if (getWorkTypes(false).Count > 0) {
                foreach(WorkType workType in getWorkTypes(false))
                {
                    dataTable.Rows.Add(new object[] { workType.id,
                                                      workType.code,
                                                      workType.name,
                                                     workType.activeFlag
                    });
                }
            }
            return dataTable;
        }

        public DataTable getProjectDataTable() {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Code");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Work Type");
            dataTable.Columns.Add("Is Active?");

            if (getProjects(false).Count > 0) {
                foreach (Project project in getProjects(false)){
                    dataTable.Rows.Add(new object[] { project.id,
                                                      project.code,
                                                      project.name,
                                                      project.workType.name,
                                                      project.activeFlag

                    });
                }
            }
            return dataTable;
        }

        public DataTable getTaskTypeDataTable() {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Code");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Is Active?");

            if (getTaskTypes(false).Count > 0)
            {
                foreach (TaskType taskType in getTaskTypes(false))
                {
                    dataTable.Rows.Add(new object[] { taskType.id,
                                                      taskType.code,
                                                      taskType.name,
                                                      taskType.activeFlag

                    });
                }
            }
            return dataTable;
        }

        public LookupBean getLookupBean() {
            return new LookupBean();
        }
    }
}
