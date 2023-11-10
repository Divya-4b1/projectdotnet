using static DoctorBLLLibrary.DoctorServices;
using DoctorDALLibrary;
using DoctorModelLibrary;

namespace DoctorBLLLibrary
{
    public class DoctorServices : IDoctorServices
    {

        IRepository repository;
        public DoctorServices()
        {
            repository = new DoctorRepository();
        }
        /// <summary>
        /// Adds the product to the collection using the repository
        /// </summary>
        /// <param name="product">The product to be added</param>
        /// <returns></returns>
        /// <exception cref="NotAddedException">Product Id duplicated</exception>
        public product AddDoctor(product product)
        {
            var result = repository.Add(product);
            if (result != null)
            {
                return result;
            }
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

        public product updateexperience(int id, int Experirnce)
        {
            var product = GetProduct(id);
            if (product != null)
            {
                product.Experience = Experirnce;
                var result = repository.Update(product);
                return result;
            }
            throw new NoSuchProductException();
        }

        public product Updatephonenumber(int id, int phonenumber)
        {
            var product = GetProduct(id);
            if (product != null)
            {

                product.phonenumber = phonenumber;
            }

            else
                throw new InValidUpdateActionException();
        }
    }
}
        