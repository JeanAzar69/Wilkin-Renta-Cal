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
        private IMongoCollection<T> Conn<T>(string coleccion)
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://Pyra:TuNoMeteCabra@rentalcarhostbd.dzl1jd1.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("RentalBD");

            return database.GetCollection<T>(coleccion);
        }

        public void addCar(string marca, string modelo, string precio, string estatus)
        {
            var usersCollection = Conn<models>("cars");

            var insert = new models() { Marca = marca, Modelo = modelo, Precio = precio, Disponibilidad = estatus };
            usersCollection.InsertOne(insert);   
        }

        public List<models> ReadAllDocument()
        {
            List<models> list = Conn<models>("cars").AsQueryable().ToList();

            return list;
        }

        /* public void deleteCar(string marca, string modelo, string precio, string estatus)
         {
             var usersCollection = Conn<models>("cars");

             var delete = new models() { Marca = marca, Modelo = modelo, Precio = precio, Disponibilidad = estatus };
             usersCollection.DeleteMany(delete);
         }*/


        public List<models> FilterId(string id)
        {
            var userCollection = Conn<models>("cars");
            bool confirmador = false;

            List<models> filter = userCollection.Find(d => true).ToList();

            for (int i = 0; i < filter.Count(); i++)
            {
                if (filter[i].Id == id)
                {
                   confirmador = true;
                }
                
            }

            if (confirmador == false)
            {
                List<models> list = Conn<models>("cars").AsQueryable().ToList();
                MessageBox.Show("busqueda fallida");
                return list;
            }
            else
            {
                MessageBox.Show("busqueda exitosa");
                return filter = userCollection.Find(d => d.Id == id).ToList(); 
            }
            
        }

    }
}
