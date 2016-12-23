using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brunner.Eval.Data.Repository
{
    public class OrderRepository:IOrderRepository
    {
        public void Save(int orderID)
        {
            throw new NotImplementedException();
        }

       

        public Entity.Order Get(int orderID)
        {
            throw new NotImplementedException();
        }

        public void Save(Entity.Order order)
        {
            throw new NotImplementedException();
        }
    }
}
