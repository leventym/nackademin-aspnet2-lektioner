﻿using _00_WebApi.Models.Entities;
using _00_WebApi.Models.Product;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace _00_WebApi.Service
{
    public interface IProductService
    {
        Task<Product> CreateAsync(Product product);
        Task<IEnumerable<Product>> GetAll();
        Task<Product> Get(string articleNumber);
    }
    public class ProductService : IProductService
    {
        private readonly DatabaseContext _db;
        //Ta in AutoMapper
        private readonly IMapper _mapper;

        public ProductService(DatabaseContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            if (await _db.Products.AnyAsync(x => x.ArticleNr == product.ArticleNumber))
            {
                return null!;
            }

            //Ange konvertering från Product till ProductEntity
            var productEntity = _mapper.Map<ProductEntity>(product);

            await _db.Products.AddAsync(productEntity);
            await _db.SaveChangesAsync();

            //Ange konverterings delen från AutoMapper
            return _mapper.Map<Product>(productEntity);

        }

        public async Task<Product> Get(string articleNumber)
        {
            return _mapper.Map<Product>(await _db.Products.FirstOrDefaultAsync(x => x.ArticleNr == articleNumber));
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return _mapper.Map<IEnumerable<Product>>(await _db.Products.ToListAsync());
        }
    }
}
