using Brunner.Eval.Data.Entity;
using Brunner.Eval.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brunner.Eval.Services
{
    public class ShoppingCartService:IShoppingCartService
    {

        ICartRepository repo;

        public ShoppingCartService(ICartRepository repo)
        {
            this.repo = repo;
        }

        public ShoppingCart GetShoppingCartByID(Guid UserID)
        {

            ShoppingCart cart = repo.GetByUserID(UserID);

            
            if(cart == null)
            {
                cart = new ShoppingCart();
                cart.UserID = UserID;
                repo.Save(cart);
            }
            return cart;
        }

        public ShoppingCart GetTempShoppingCart()
        {
            ShoppingCart cart = new ShoppingCart();
            repo.Save(cart);
            return cart;
        }

        public void Save(ShoppingCart cart)
        {
            repo.Save(cart);
        }

        public decimal GetTotal(ShoppingCart cart, IDiscountRepository repo)
        {
            DiscountServices ser = new DiscountServices(repo);
           

            if(repo.GetAllDiscountTypes().Count() > 0)
            {
                ser.ApplyDiscountRates(cart);
                return cart.CartItems.Sum(x => x.TotalPrice);
            }
            else
            {
                return cart.CartItems.Sum(x => x.UnitPrice * x.Quantity);
            }
          

        }
    }
}
