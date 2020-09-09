using OA_DataAccess;
using OA_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_Service
{
    public class ProductService:IProductService
    {
        private IRepository<Product> productrepo;
        private IRepository<ProductDetails> productdetailsrepo;
        public ProductService(IRepository<Product> productrepo , IRepository<ProductDetails> productdetailsrepo)
        {
            this.productrepo = productrepo;
            this.productdetailsrepo = productdetailsrepo;
        }
         public IEnumerable<Product> GetProduct()
        {
            return productrepo.GetAll();
        }

        public Product Getproduct(int id)
        {
            return productrepo.Get(id);
        }
    }
}
