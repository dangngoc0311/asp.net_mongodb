using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_MongoDB.Models
{
    public class OrderItem
    {
        public ObjectId BookId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        [BsonIgnore]
        public string BookName { get; set; }
        [BsonIgnore]
        public string Image { get; set; }
    }
}
