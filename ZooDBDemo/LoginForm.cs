using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLibrary;

namespace ZooDBDemo
{
    public partial class LoginForm : Form
    {
        List<User> roster = new List<User>();
        bool employee;

        public LoginForm()
        {
            InitializeComponent();
        }



        private void loginID_TextChanged(object sender, EventArgs e)
        {

            ;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Create User object with inputs that will
            //be used to verify the account validity and
            //accesses on Save click

            string userid = loginID.Text;
            User current = new User();
            current.UserID = int.Parse(userid);

            //check to see if valid ID
            employee = DBConnector.Validate(current);

            //Invalid ID, not an employee
            if (employee == false)
            {
                MessageBox.Show("Invalid User ID. Please try again");
                loginID.Text = "";
               
            }

            else
            {
                //Valid ID, proceed to granting access
                current.JobTitle = DBConnector.Access(current);

                this.Hide();
                LandingPage f1 = new LandingPage();
                //MessageBox.Show(current.JobTitle);

                //grant accesses
                f1.Access(current.JobTitle);
                f1.ShowDialog();
                this.Close();//added
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
