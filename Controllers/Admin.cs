using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Election_System.Controllers
{
    public partial class Admin : Form
    {
        private Dictionary<string, UserControl> navigationStates = new Dictionary<string, UserControl>()
        {
           {"dashboard",new AdminDashboard(){ Dock = DockStyle.Fill } },
           {"election",new Election(){ Dock = DockStyle.Fill } },
           {"candidates",new Candidates(){ Dock = DockStyle.Fill } },
           {"voters",new Voters(){ Dock = DockStyle.Fill } }
        };
        public Admin()
        {
            InitializeComponent();
            SetPage("dashboard");
        }
        public void SetPage(string page)
        {
            Admin admin = (Admin)this.FindForm();
            admin.panel10.Controls.Clear();
            admin.panel10.Controls.Add(navigationStates[page]);
        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            SetPage("dashboard");
        }

        private void election_button_Click(object sender, EventArgs e)
        {
            SetPage("election");
        }

        private void candidates_button_Click(object sender, EventArgs e)
        {
            SetPage("candidates");
        }

        private void voters_button_Click(object sender, EventArgs e)
        {
            SetPage("voters");
        }

        private void logout_button_Click(object sender, EventArgs e)
        {

        }
    }
}
