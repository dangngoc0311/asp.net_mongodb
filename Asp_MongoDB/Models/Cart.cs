using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_MongoDB.Models
{
    public class Cart
    {
        public string BookId { get; set; }

        public string BookName { get; set; }

        public string Image { get; set; }
        public float Price { get; set; }

        public int Quantity { get; set; }
    }
}
