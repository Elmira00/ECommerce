﻿using Ecommerce.Business.Abstract;
using Ecommerce.DataAccess.Abstraction;
using Ecommerce.Entities.Models;

namespace Ecommerce.Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task AddAsync(Product product)
        {
            await _productDal.Add(product);
        }

        public async Task DeleteAsync(int id)
        {
            var item = await _productDal.Get(p => p.ProductId == id);
            await _productDal.Delete(item);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _productDal.GetList();
        }

        public async Task<List<Product>> GetAllByCategoryAsync(int categoryId)
        {
            return await _productDal.GetList(p => p.CategoryId == categoryId || categoryId == 0);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _productDal.Get(p => p.ProductId == id);
        }

        public async Task UpdateAsync(Product product)
        {
            await _productDal.Update(product);
        }
    }
}