using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_MongoDB.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string BookId { get; set; }

        [Required]
        [BsonRequired]
        [BsonElement("BookName")]
        public string BookName { get; set; }
        [BsonRequired]
        [BsonElement("Author")]
        [Required]
        public string Author { get; set; }
        [BsonRequired]
        [BsonElement("Image")]
        public string Image { get; set; }
        [BsonRequired]
        [BsonElement("Description")]
        [Required]
        public string Description { get; set; }
        [BsonRequired]
        [BsonElement("Price")]
        [Required]
        public float Price { get; set; }
        [BsonRequired]
        [BsonElement("Quantity")]
        [Required]
        public int Quantity { get; set; }

        [BsonElement("Category")]
        public ObjectId Category { get; set; }

        [BsonIgnore]
        public string CategoryName { get; set; }
    }
}
