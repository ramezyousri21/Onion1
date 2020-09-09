using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace OA_DataAccess
{
    public class ProductMap
    {
        public ProductMap (EntityTypeBuilder<Product> entitybuilder)
        {
            entitybuilder.HasKey(p => p.ProductID);
            entitybuilder.HasOne(p => p.ProductDetails).WithOne(p => p.Product).HasForeignKey<ProductDetails>(x => x.ProductID);
        }
    }
}
