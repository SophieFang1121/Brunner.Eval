using Brunner.Eval.Data.Entity;
using Brunner.Eval.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brunner.Eval.Constant;

namespace Brunner.Eval.Services
{
    public class DiscountServices
    {
        IDiscountRepository repo;
        public DiscountServices(IDiscountRepository repo)
        {
            this.repo = repo;
        }

        public void  ApplyDiscountRates(ShoppingCart cart)
        {
           var types = repo.GetAllDiscountTypes();
            
            //Usage of Discount Types not completely implemented, we can automatr for all prodcuts driven from Database


            //Buy One Get One Free  - Discount Type -1
            BuyXGetYFree(cart.CartItems.Where(x=>x.ProductName ==Item.Apple).ToList(), 1, 1);

            //Buy Two Get One Free  - Discount Type -2
            
            BuyXGetYFree(cart.CartItems.Where(x => x.ProductName == Item.Orange).ToList(), 2, 1);
           
        }

        private void BuyXGetYFree(List<CartItem> lItems, int X, int Y)
        {
         
            foreach (CartItem cI in lItems)
            {
                if (cI.Quantity > X)
                {
                    cI.TotalPrice = ((cI.Quantity / (X + Y) * X) + (cI.Quantity % (X + Y))) * cI.UnitPrice;
                }
            }
        }
    }
}
