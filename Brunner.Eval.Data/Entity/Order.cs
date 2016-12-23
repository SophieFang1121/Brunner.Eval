using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brunner.Eval.Data.Entity
{
    public class Order
    {
        public int ID { get; set; }
        public Guid UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderStatus { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
    