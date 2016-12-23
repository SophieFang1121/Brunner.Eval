
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brunner.Eval.Data.Repository;
using Brunner.Eval.Data.Entity;
using Brunner.Eval.Constant;

namespace Brunner.Eval.Web.Tests.Mocks
{
   public  class DiscountMockRepository :  IDiscountRepository
    {
        public IDictionary<int, int> GetAllDiscountTypes()
        {

            
           return  new Dictionary<int, int>() {{(int)Item.Apple,(int)OfferType.BuyOneGetOne
           },{(int)Item.Orange,(int)OfferType.BuyTwoGetOne} };
            
        }

        public int GetDiscountType(int productID)
        {
            throw new NotImplementedException();
        }   
    }

   public class NoDiscountMockRepository : IDiscountRepository
   {
       public IDictionary<int, int> GetAllDiscountTypes()
       {

           
           return new Dictionary<int, int>() { };
       }

       public int GetDiscountType(int productID)
       {
           throw new NotImplementedException();
       }
   }
}
