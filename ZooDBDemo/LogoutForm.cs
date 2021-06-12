using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooDBDemo
{
    public partial class LogoutForm : Form
    {
        public LogoutForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
             
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LandingPage f1 = new LandingPage();
            f1.Hide();
            LoginForm f2 = new LoginForm();
            f2.ShowDialog();
            this.Close();//added
        }
    }
}
