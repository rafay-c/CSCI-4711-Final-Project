using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using DemoLibrary;

namespace ZooDBDemo
{
    public partial class RecordFeedingPage : Form
    {
        List<FeedData> feeddata = new List<FeedData>();
        List<Animal> animals = new List<Animal>();
        public RecordFeedingPage()
        {
            InitializeComponent();
            LoadAnimalList();
        }

        private void LoadAnimalList()
        {
            animals = DemoLibrary.DBConnector.GetAnimalPickerSelection();
            WireUp();
        }

        private void WireUp()
        {
            AnimalPicker.DataSource = null;
            AnimalPicker.DataSource = animals;
            AnimalPicker.DisplayMember = "Entry";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AnimalName = AnimalPicker.Text;
            int IDLocation = AnimalName.IndexOf(',');
            string AnimalID = AnimalName.Substring(0, IDLocation);
            string DatePicked = DatePicker.Value.ToString("MM/dd/yyyy");
            string TimePicked = TimePicker.Value.ToString("HH:mm");
            string DateAndTime = DatePicked + " " + TimePicked;
            
            
            FeedData a = new FeedData();

            a.AID = AnimalID;
            a.TimeFed = DateAndTime;

            DBConnector.UpdateFeedingTime(a);

            this.Hide();
            LandingPage f1 = new LandingPage();
            f1.ShowDialog();
            this.Close();//added
        }

        private void AnimalPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
