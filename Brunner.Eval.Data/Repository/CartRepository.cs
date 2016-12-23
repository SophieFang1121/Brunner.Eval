using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brunner.Eval.Data.Repository
{
    public class CartRepository:ICartRepository
    {
        public void Save(Entity.ShoppingCart cart)
        {
            throw new NotImplementedException();
        }

       

        public Entity.ShoppingCart GetByUserID(Guid ID)
        {
            throw new NotImplementedException();
        }


        public Entity.ShoppingCart GetByCartNumber(string number)
        {
            throw new NotImplementedException();
        }
    }
}
