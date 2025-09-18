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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }
        private void no_acc_label_Click(object sender, EventArgs e)
        {
            LandingPage register = (LandingPage)this.FindForm();
            register.ShowPage("register");

        }
        private void login_bttn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text.Equals("99999999") && password_textBox.Text.Equals("admin"))
                new Admin().Show();
        }
    }
}
