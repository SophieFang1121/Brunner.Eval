using Brunner.Eval.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brunner.Eval.Data.Repository
{
    public interface ICartRepository
    {
         void Save(ShoppingCart cart);
         ShoppingCart GetByCartNumber(string number);
         ShoppingCart GetByUserID(Guid ID);

    }
}
