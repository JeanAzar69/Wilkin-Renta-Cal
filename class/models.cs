using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RentaCal
{
    public class models
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("marca")]
        public string Marca { get; set; }

        [BsonElement("modelo")]
        public string Modelo { get; set; }

        [BsonElement("precio")]
        public string Precio { get; set; }

        [BsonElement("disponibilidad")]
        public string Disponibilidad { get; set; }

    }
}
