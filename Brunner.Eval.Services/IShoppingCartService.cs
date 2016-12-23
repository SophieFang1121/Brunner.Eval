using Brunner.Eval.Data.Entity;
using Brunner.Eval.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brunner.Eval.Services
{
    public interface IShoppingCartService
    {
         ShoppingCart GetShoppingCartByID(Guid UserID);
         ShoppingCart GetTempShoppingCart();
         void Save(ShoppingCart cart);
         decimal GetTotal(ShoppingCart cart,IDiscountRepository dr);
    }
}
