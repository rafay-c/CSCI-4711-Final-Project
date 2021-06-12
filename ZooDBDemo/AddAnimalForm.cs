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
    public partial class AddAnimalForm : Form

    {
        List<Animal> animals = new List<Animal>();//create animal list

        public AddAnimalForm()//constructor
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)//move to controller 
        {
            string newName = animalName.Text;
            string newSpecies = animalSpecies.Text;
            string received = dateReceived.Value.ToString("MM/dd/yyyy");

            Animal a = new Animal();
            FeedData b = new FeedData();


            a.Name = newName;
            a.Species = newSpecies;
            a.DateReceived = received;

            b.TimeFed = "null";

            DBConnector.Save(a);
            DBConnector.CreateFeedData(b);

            this.Hide();
            LandingPage f1 = new LandingPage();
            f1.ShowDialog();
            this.Close();//added

        }

        private void animalName_Click(object sender, EventArgs e)
        {
            ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
