﻿using OA_DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA_Service
{
    public interface IProductService
    {
        IEnumerable<Product> GetProduct();
        OA_DataAccess.Product Getproduct(int id);
    }
}
