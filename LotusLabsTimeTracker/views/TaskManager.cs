using LotusLabsTimeTracker.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotusLabsTimeTracker.views
{
    public partial class TaskManager : Form
    {
        private MaintenanceMenu _maintenanceMenu;
        private Users currentSessionUser;
        public TaskManager(MaintenanceMenu maintenanceMenu)
        {
            InitializeComponent();
            _maintenanceMenu = maintenanceMenu;
        }

        private void btn_taskType_Click(object sender, EventArgs e)
        {
            TaskType task = new TaskType(this);
            task.setCurrentSessionUser(this.currentSessionUser);
            task.Show();
            this.Hide();
        }

        private void btn_projectType_Click(object sender, EventArgs e)
        {
            ProjectType project = new ProjectType(this);
            project.setCurrentSessionUser(this.currentSessionUser);
            project.Show();
            this.Hide();
        }

        private void btn_workType_Click(object sender, EventArgs e)
        {
            WorkType work = new WorkType(this);
            work.setCurrentSessionUser(this.currentSessionUser);
            work.Show();
            this.Hide();
        }

        public Users getCurrentSessionUser()
        {
            return this.currentSessionUser;
        }

        public void setCurrentSessionUser(Users currentSessionUser)
        {
            this.currentSessionUser = currentSessionUser;
        }

        private void TaskManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            _maintenanceMenu.Show();
        }

        private void TaskManager_Load(object sender, EventArgs e)
        {

        }
    }
}
