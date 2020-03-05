using eTicaret.DataAccess.Abstract;
using eTicaret.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTicaret.DataAccess.Concrete.EfCore
{
   public class EfCoreOrderDal :EfCoreGenericRepository<Order,ShopContext>, IOrderDal
    {

    }
}
