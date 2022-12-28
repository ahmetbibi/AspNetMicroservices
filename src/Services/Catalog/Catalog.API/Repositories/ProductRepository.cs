﻿using Catalog.API.Data;
using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly ICatalogContext _context;

        public ProductRepository(ICatalogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Task CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProduct(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProducts() => await _context
                                                                           .Products
                                                                           .Find(prop => true)
                                                                           .ToListAsync();

        public Task<bool> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
