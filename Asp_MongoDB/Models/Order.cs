using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_MongoDB.Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string OrderId { get; set; }

        [BsonElement("FullName")]
        [Required]
        public string FullName { get; set; }

        [BsonElement("EmailAddress")]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [BsonElement("ContactNumber")]
        [Required]
        [Phone]
        public string ContactNumber { get; set; }

        [BsonElement("Address")]
        [Required]
        public string Address { get; set; }

        [BsonElement("Price")]
        [Required]
        public double Price { get; set; }

        [BsonElement("Note")]
        public string Note { get; set; }

        [BsonElement("CreatedAt")]
        public DateTime? CreatedAt { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
