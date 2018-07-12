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
    public partial class MaintenanceMenu : Form
    {
        public MaintenanceMenu()
        {
            InitializeComponent();
        }

        private void btn_prodMgr_Click(object sender, EventArgs e)
        {
            ProfileManager profileMgr = new ProfileManager();
            profileMgr.Show();
            this.Hide();
        }

        private void btn_taskMgr_Click(object sender, EventArgs e)
        {
            TaskManager taskMgr = new TaskManager();
            taskMgr.Show();
            this.Hide();
        }
    }
}
