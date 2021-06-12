using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using DemoLibrary;

namespace ZooDBDemo
{
    public partial class LandingPage : Form
    {
        //instntiate forms
        List<Animal> animals = new List<Animal>();
        List<FeedData> feeddata = new List<FeedData>();
        //LandingPage landingpage = new LandingPage();
        RecordFeedingPage recordpage = new RecordFeedingPage();
        AddAnimalForm addanimalpage = new AddAnimalForm();
        

        public LandingPage()//constructor
        {
            InitializeComponent();
            LoadAnimalList();
            GetLoadFeedData();


        }

        public void Access(string cred)//checking permissions
        {
            if (cred.Contains("C"))
            {
                button1.Enabled = false;
            }
        }
        private void LoadAnimalList()//load list to left side from dbConnector
        {

            animals = DemoLibrary.DBConnector.LoadZooInfo();
            WireUp();
        }
        private void GetLoadFeedData()//load list to right side for feed data
        {

            feeddata = DemoLibrary.DBConnector.GetLoadFeedData();
            WireUp2();
        }
        private void WireUp()//display animals in listbox
        {
            listBox1.DataSource = null;
            listBox1.DataSource = animals;
            listBox1.DisplayMember = "Entry";
        }

        private void WireUp2()//display feed data
        {
            listBox2.DataSource = null;
            listBox2.DataSource = feeddata;
            listBox2.DisplayMember = "Entry";
        }

        private void button3_Click(object sender, EventArgs e)//logout button
        {

            LogoutForm f1 = new LogoutForm();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)//Record feeding button
        {
            this.Hide();
            recordpage.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)//add animal
        {
            this.Hide();
            addanimalpage.ShowDialog();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
