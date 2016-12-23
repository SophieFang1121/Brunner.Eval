using Brunner.Eval.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brunner.Eval.Data.Repository
{
    public interface IOrderRepository
    {
         void Save(Order order);
         Order Get(int orderID);
    }
}
