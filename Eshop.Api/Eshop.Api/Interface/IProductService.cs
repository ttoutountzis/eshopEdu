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

       

        bool DeleteProductItem(string id);
        
    }
}
