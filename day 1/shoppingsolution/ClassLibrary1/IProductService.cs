using shoppingDALlibrary;
using shoppingmodellibrary;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBLLibrary
{
    public interface IProductService
    {
        public product AddProduct(product product);
        public product UpdateProductPrice(int id, float price);
        public product GetProduct(int id);
        public List<product> GetProducts();
        public product UpdateProductQuantity(int id, int quantity, string action);
        public product Delete(int id);
    }
}
