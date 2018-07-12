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
    public partial class LeaveForm : Form
    {
        public LeaveForm()
        {
            InitializeComponent();
        }

        private void lnk_viewPMEF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FIledLeaveForm fIledLeave = new FIledLeaveForm();
            fIledLeave.Show();
            this.Hide();
        }
    }
}
