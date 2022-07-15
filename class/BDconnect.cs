using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Driver;
using System.Windows.Forms;
using RentaCal;

namespace RentaCal
{
    public class BDconnect
    {

        private string ConnectionString = $"mongodb+srv://Pyra:{Environment.GetEnvironmentVariable("USERDBPASS")}@cluster0.9zhwp.mongodb.net/{Environment.GetEnvironmentVariable("DBNAME")}?retryWrites=true&w=majority";
        private string DBname = Environment.GetEnvironmentVariable("DBNAME");
        private string colecction = Environment.GetEnvironmentVariable("COLECCTION");

        private IMongoCollection<T> Conn<T>(string coleccion)
        {
            var client = new MongoClient(ConnectionString);
            var DB = client.GetDatabase(DBname);
            return DB.GetCollection<T>(coleccion);
        }

        //public bool addCar(string marca, string modelo, int precio, string estatus)
        //{
        //    bool valid = true;
        //    var usersCollection = Conn<models>(colecction); 

        //    List<models> results = usersCollection.Find(_ => true).ToList();

        //    for (int i = 0; i < results.Count; i++)
        //    {
        //        if (results[i])
        //        {

        //        }

        //    }
        //}

    }
}
