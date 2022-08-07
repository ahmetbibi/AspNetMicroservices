using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            /* 
             * Create a MongoClient object to access to DB, so use DB string
             * In order to access to appsettings we have to inject IConfiguration interface as a parameter to this constructor (Dependency Injection)
             */
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConnectionString"));
            // This method creates a db if it is not exists
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:DatabaseName"));

            // We are populating Products collection
            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:CollectionName"));

            // We are seeding the data
            CatalogContextSeed.SeedData(Products);
        }

        public IMongoCollection<Product> Products { get; }
    }
}
