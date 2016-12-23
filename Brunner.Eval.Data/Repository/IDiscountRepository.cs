using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brunner.Eval.Data.Repository
{
    public interface IDiscountRepository
    {
         IDictionary<int, int> GetAllDiscountTypes();
         int GetDiscountType(int productID);

    }
}
