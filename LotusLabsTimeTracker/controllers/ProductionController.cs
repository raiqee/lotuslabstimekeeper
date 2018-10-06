using LotusLabsTimeTracker.model;
using LotusLabsTimeTracker.services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusLabsTimeTracker.controllers
{
    class ProductionController
    {
        public List<String> validateUserTask(UserTask userTask)
        {
            List<String> errMessages = new List<string>();
            if (userTask.workType.id == 0)
            {
                errMessages.Add("Work Type is required");
            }

            if (userTask.project.id == 0) {
                errMessages.Add("Project is required");
            }
            if (userTask.taskType.id == 0) {
                errMessages.Add("Task Type is required");
            }
            return errMessages;
        }

        public UserTask saveUserTask(UserTask userTask, Boolean isNew, Users user)
        {
            if (isNew)
            {
                userTask.createdBy = user.id;
                userTask.createdDate = DateTime.Now;
            }
            userTask.updatedBy = user.id;
            userTask.updatedDate = DateTime.Now;
            return getUserTaskBean().saveUserTask(userTask);
        }

        public void deleteUserTask(long id) {
            getUserTaskBean().deleteUserTask(id);
        }

        public DataTable getUserTasks(Users user, WorkType workType, Project project, TaskType taskType, DateTime start, DateTime end)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Employee Number");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Task");
            dataTable.Columns.Add("Project");
            dataTable.Columns.Add("Work Type");
            dataTable.Columns.Add("Details");
            dataTable.Columns.Add("Start Time");
            dataTable.Columns.Add("End Time");

            if (getProductionBean().getUserTasks(user, workType, project, taskType, start, end).Count > 0)
            {
                foreach (UserTask userTask in getProductionBean().getUserTasks(user, workType, project, taskType, start, end))
                {
                    dataTable.Rows.Add(new object[] { userTask.id,
                                                      String.Format("{0:MM/dd/yy}",userTask.createdDate),
                                                      getFullName(userTask.user),
                                                      userTask.taskType.name,
                                                      userTask.project.name,
                                                      userTask.workType.name,
                                                      userTask.description,
                                                      userTask.startDateTime,
                                                      userTask.endDateTime
                    });
                }
            }
            return dataTable;
        }

        public UserTask getUserTask(long id) {
            return getUserTaskBean().getUserTask(id);
        }

        public UserTaskBean getUserTaskBean() {
            return new UserTaskBean();
        }

        public ProductionBean getProductionBean() {
            return new ProductionBean();
        }

        public String getFullName(Users user)
        {
            if (user != null)
            {
                return user.lastName + ", " + user.firstName + " " + user.middleName;
            }
            return "";
        }
    }
}
