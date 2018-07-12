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
    public partial class ProfileManager : Form
    {
        public ProfileManager()
        {
            InitializeComponent();
        }

        private void lnk_addNewEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addNewUser newUser = new addNewUser();
            newUser.Show();
            this.Hide();
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            editUser.Show();
            this.Hide();
        }
    }
}
