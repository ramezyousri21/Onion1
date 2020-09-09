using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_DataAccess
{
    public class ProductDetailMap
    {
        public ProductDetailMap(EntityTypeBuilder<ProductDetails> entitybuilder)
        {
            entitybuilder.HasKey(pd => pd.ProductID);
            entitybuilder.Property(p => p.StockAvailable).IsRequired();
            entitybuilder.Property(p => p.Price);

        }
    }
}
