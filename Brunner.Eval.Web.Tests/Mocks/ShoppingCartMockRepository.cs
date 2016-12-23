
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brunner.Eval.Data.Repository;
using   Brunner.Eval.Data.Entity;
namespace Brunner.Eval.Web.Tests.Mocks
{
    public class ShoppingCartMockRepository:ICartRepository
    {
        private List<ShoppingCart> list = new List<ShoppingCart>();
        public ShoppingCartMockRepository()
        {

            ShoppingCart cart = new ShoppingCart();
            cart.CartItems = new List<CartItem>();
            cart.UserID = new Guid("E5615A03-1E31-427C-857C-2011A5FAD6B7");
            cart.CartStartDate = DateTime.Now;
            cart.CartStatus = 1;
            cart.ShoppingCartNumber = "X1235124";
            list.Add(cart);
        }

        public void Save(ShoppingCart cart)
        {
            throw new NotImplementedException();
        }

        public ShoppingCart GetByCartNumber(string number)
        {
            throw new NotImplementedException();
        }

        public ShoppingCart GetByUserID(Guid ID)
        {

            return list.Where(x => x.UserID == ID && x.CartStatus == 1).FirstOrDefault();
            
        }
    }
}
