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
        public bool search(string id)
        {
            var userCollection = Conn<models>("cars");
            int count = 0;

            List<models> buscar = userCollection.Find(d => true).ToList();

            for (int i = 0; i < buscar.Count(); i++)
            {
                if (buscar[i].Id == id)
                {
                    count++;
                }
            }

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

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

        public void update(string id, string marca, string modelo, string precio, string disponibilidad)
        {
            var userCollection = Conn<models>("cars");

            List<models> list = userCollection.Find(d => true).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                {
                    var update = new models() {Id = id, Marca = marca, Modelo = modelo, Precio = precio, Disponibilidad = disponibilidad };
                    userCollection.ReplaceOne(d => d.Id == id, update);
                }
            }
        }

        public void delete(string id, string marca, string modelo, string precio, string disponibilidad)
        {
            var userCollection = Conn<models>("cars");

            List<models> list = userCollection.Find(d => true).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                {
                    var delete = new models() { Id = id, Marca = marca, Modelo = modelo, Precio = precio, Disponibilidad = disponibilidad };
                    userCollection.DeleteOne(d => d.Id == id);
                }
            }
        }

        public List<models> disponible()
        {
            var userCollection = Conn<models>("cars");

            List<models> filter = userCollection.Find(d => d.Disponibilidad == "Disponible").ToList();

            return filter;
        }

        public bool rent(string id)
        {
            var userCollection = Conn<models>("cars");
            bool confirmador = false;
            List<models> list = userCollection.Find(d => true).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                {
                    var update = new models() {Id = id, Marca = list[i].Marca, Modelo = list[i].Modelo, Precio = list[i].Precio, Disponibilidad = "Ocupado"};
                    userCollection.ReplaceOne(d => d.Id == id, update);
                    confirmador = true;
                }
            }

            return confirmador;
        }

    }
}
