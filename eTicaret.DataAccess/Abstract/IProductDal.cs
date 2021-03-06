﻿using eTicaret.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTicaret.DataAccess.Abstract
{
    public interface IProductDal : IRepository<Product>
    {
        IEnumerable<Product> GetPopularProducts();
    }
}
