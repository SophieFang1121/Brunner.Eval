using Brunner.Eval.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brunner.Eval.Data.Entity
{
    public class ShoppingCart
    {
        public int ID { get; set; }
        public Guid? UserID { get; set; }
        public DateTime CartStartDate { get; set; }
        public int CartStatus { get; set; }
        public List<CartItem> CartItems { get; set; }
        public string ShoppingCartNumber { get;  set; }

       
    }
}
