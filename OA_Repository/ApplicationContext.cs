using Microsoft.EntityFrameworkCore;
using OA_DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace OA_Repository
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            new ProductMap(modelbuilder.Entity<Product>());
            new ProductDetailMap(modelbuilder.Entity<ProductDetails>());
        }
    }
}
