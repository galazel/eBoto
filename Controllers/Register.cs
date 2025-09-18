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
    public partial class Register : UserControl
    {
        private VoterService service = new VoterService();
        public Register()
        {
            InitializeComponent();
        }

        private void no_acc_label_Click(object sender, EventArgs e)
        {
            LandingPage login = (LandingPage)this.FindForm();
            login.ShowPage("login");
        }
        public void Save
    }
}
