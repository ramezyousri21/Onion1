using OA_DataAccess;
using OA_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_Service
{
    public class ProductDetailService : IProductDetailService
    {
        private IRepository<ProductDetails> productDetailsRepo;
        public ProductDetailService(IRepository<ProductDetails> productDetailsRepo)
        {
            this.productDetailsRepo = productDetailsRepo;
        }

        public ProductDetails GetProductDetails(int id)
        {
            return productDetailsRepo.Get(id);
        }
    }
}
