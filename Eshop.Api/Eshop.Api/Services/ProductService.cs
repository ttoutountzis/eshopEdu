using Eshop.Api.Context;
using Eshop.Api.Interface;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Api.Services
{
    public class ProductService : IProductService
    {
        private MsDbContext _ctx;

        public ProductService(MsDbContext ctx)
        {
            _ctx = ctx;
        }

        public bool DeleteProductItem(string id)
        {
            ProductItem product = _ctx.Products.Find(id);
            if (product == null)
            {
                return false;
            }
            _ctx.Products.Remove(product);
            _ctx.SaveChanges();
            return true;
        }

        public ProductItem GetProductItem(string id)
        {
            return new ProductItem();
        }

        public ProductItem InsertProductItem(ProductItem productitem)
        {
            _ctx.Products.Add(productitem);
            _ctx.SaveChanges();
            return productitem;

        }

        public List<ProductItem> GetAll()
        {
            return _ctx.Products.ToList();
        }

        public ProductItem Update(ProductItem productItem)
        {
            var result = _ctx.Products.SingleOrDefault(u => u.Id.Equals(productItem.Id));
            try
            {
                _ctx.Entry(result).CurrentValues.SetValues(productItem);
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return productItem;

        }
       
    }
}
