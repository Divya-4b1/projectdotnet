using shoppingmodellibrary;

namespace shoppingDALlibrary
{
    public class ProductRepository : IRepository<int,product>
    {
        Dictionary<int,product> products = new Dictionary<int,product>();

        /// <summary>
        /// Adds the given product to the dictionary 
        /// </summary>
        /// <param name="product">Product object that has to be added</param>
        /// <returns>The product that has been added</returns>
        
        public product Add(product product)
        {
            int id = GetTheNextId();
            try {  
                product.Id = id;
                products.Add(product.Id, product); 
                return product;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("the product id is already exist");
                Console.WriteLine(e.Message);
            }
            return null;

            
        
        }
        private int GetTheNextId()
        {
            if (products.Count == 0)
                return 1;
            int id = products.Keys.Max();
            return ++id;
        }

        /// <summary>
        /// Deletes the product from teh dictionary using the id as key
        /// </summary>
        /// <param name="id">The Id of the product to be deleted</param>
        /// <returns>The deleted product</returns>

        public product Delete(int id)
        {
            var product = products[id];
            products.Remove(id);
            return product;
            
        }

        public List<product> GetAll()
        {
            var productList = products.Values.ToList();
            return productList;
        }

        public product GetById(int id)
        {
            if (products.ContainsKey(id))
                return products[id];
            return null;
        }

        public product Update(product product)
        {
            products[product.Id] = product;
            return products[product.Id];
        }
    }
}