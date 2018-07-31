using LotusLabsTimeTracker.model;
using LotusLabsTimeTracker.services;
using System;
using System.Collections.Generic;
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

            if (String.IsNullOrEmpty(userTask.description))
            {
                errMessages.Add("Description is required");
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

        public UserTask getUserTask(long id) {
            return getUserTaskBean().getUserTask(id);
        }

        public UserTaskBean getUserTaskBean() {
            return new UserTaskBean();
        }
    }
}
