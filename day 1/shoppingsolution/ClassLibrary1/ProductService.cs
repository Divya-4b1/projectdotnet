﻿using shoppingDALlibrary;
using shoppingmodellibrary;

namespace ShoppingBLLibrary
{
    public class ProductService : IProductService
    {
        IRepository<int,product> repository;
        public ProductService()
        {
            repository = new ProductRepository();
        }
        /// <summary>
        /// Adds the product to the collection using the repository
        /// </summary>
        /// <param name="product">The product to be added</param>
        /// <returns></returns>
        /// <exception cref="NotAddedException">Product Id duplicated</exception>
        public product AddProduct(product product)
        {
            var result = repository.Add(product);
            if (result != null)
                return result;
            throw new NotAddedException();
        }

        public product Delete(int id)
        {
            var product = GetProduct(id);
            if (product != null)
            {
                repository.Delete(id);
                return product;
            }
            throw new NoSuchProductException();
        }
        /// <summary>
        /// Returns the product for teh given Id
        /// </summary>
        /// <param name="id">Id of the product to be returned</param>
        /// <returns></returns>
        /// <exception cref="NoSuchProductException">No product with the given Id</exception>
        public product GetProduct(int id)
        {
            var result = repository.GetById(id);
            //if (result != null) 
            //    return result;
            //throw new NoSuchProductException();

            //null collasing operator
            //return result ?? throw new NoSuchProductException();

            return result == null ? throw new NoSuchProductException() : result;
        }

        public List<product> GetProducts()
        {
            var products = repository.GetAll();
            if (products.Count != 0)
                return products;
            throw new NoProductsAvailableException();
        }

        public product UpdateProductPrice(int id, float price)
        {
            var product = GetProduct(id);
            if (product != null)
            {
                product.Price = price;
                var result = repository.Update(product);
                return result;
            }
            throw new NoSuchProductException();
        }

        public product UpdateProductQuantity(int id, int quantity, string action)
        {
            var product = GetProduct(id);
            if (product != null)
            {
                if (action == "add")
                {
                    product.Quantity += quantity;
                }
                else if (action == "remove")
                {
                    product.Quantity -= quantity;
                }
                else
                    throw new InValidUpdateActionException();
                var result = repository.Update(product);
                return result;
            }
            throw new NoSuchProductException();
        }
    }
}

