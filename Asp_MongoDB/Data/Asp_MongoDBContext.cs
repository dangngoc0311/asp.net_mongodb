using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_MongoDB.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace Asp_MongoDB.Data
{
    public class Asp_MongoDBContext
    {
            private IMongoDatabase _database = null;
            public Asp_MongoDBContext(IOptions<Settings> settings)
            {
                var client = new MongoClient(settings.Value.ConnectionString);
                if (client!=null)
                {
                    _database = client.GetDatabase(settings.Value.Database);
                }
            }
            public IMongoCollection<Category> Category => _database.GetCollection<Category>("Category");
            public IMongoCollection<Book> Book => _database.GetCollection<Book>("Book");
            public IMongoCollection<Order> Order => _database.GetCollection<Order>("Order");


    }
}
