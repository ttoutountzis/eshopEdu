using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Api.Interface
{
    public interface IProductService
    {
        ProductItem GetProductItem(string id);
        ProductItem InsertProductItem(ProductItem productitem);
        ProductItem Update(ProductItem productItem);
        List<ProductItem> GetAll();
        bool DeleteProductItem(string id);
        
    }
}
