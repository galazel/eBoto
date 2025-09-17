using School_Election_System.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Election_System
{
    public partial class LandingPage : Form
    {
        public Dictionary<string, UserControl> landingPage = new Dictionary<string, UserControl>()
        {
            { "login", new Login() { Dock = DockStyle.Fill, Anchor = AnchorStyles.None} },
            { "register", new Register() { Dock = DockStyle.Fill, Anchor = AnchorStyles.None} }
        };
        public LandingPage()
        {
            InitializeComponent();
            ShowPage("login");
        }
        public void ShowPage(string page)
        {
            landing_split.Panel2.Controls.Clear();
            landing_split.Panel2.Controls.Add(landingPage[page]);
        }

    }

}
