using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ZooDBDemo;

namespace DemoLibrary
{
    public class DBConnector
    {


        public static List<Animal> LoadZooInfo()//Selects everything from AnimalTable for landing page
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Animal>("SELECT * FROM Animal", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<FeedData> GetLoadFeedData()//Gets/display feed data on landing page
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<FeedData>("SELECT TimeFed FROM FeedData", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Animal> GetAnimalPickerSelection()//AnimalPickerSelection for record feed data drop down
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Animal>("SELECT AnimalID, Name FROM Animal", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void Save(Animal animal)//Animal saved from addanimal form
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Animal (Name, Species, DateReceived) values (@Name, @Species, @DateReceived)", animal);
            }
        }

        public static void UpdateFeedingTime(FeedData feedData)//FeedData updated
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE FeedData SET TimeFed = @TimeFed WHERE FID = @AID", feedData);
            }
        }

        public static void CreateFeedData(FeedData feedData)//inserts Feeddata
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO FeedData (FID, TimeFed, AID) values (@FID, @TimeFed, @AID)", feedData);
            }
        }


        public static string Access(User login)//User access/permissions
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<User>("Select JobTitle FROM User WHERE UserID = " + login.UserID.ToString(), new DynamicParameters());
                string title = "";

                foreach (var i in output)
                {
                    title = i.JobTitle; // Prints items      
                }


                return title;
            }
        }

        public static bool Validate(User current)//permissions
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<User>("Select JobTitle FROM User WHERE UserID = " + current.UserID.ToString(), new DynamicParameters());
                List<User> roster = output.ToList();
                if (roster.Count == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
