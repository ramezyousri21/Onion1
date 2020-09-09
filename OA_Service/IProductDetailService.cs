using OA_DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_Service
{
    public interface IProductDetailService
    {
        ProductDetails GetProductDetails(int id);
    }
}
