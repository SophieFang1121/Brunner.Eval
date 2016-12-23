using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brunner.Eval.Constant;

namespace Brunner.Eval.Data.Entity
{
    public class CartItem
    {
        private decimal unitPrice;
        public int ID { get; set; }
        public int CartID { get; set; }
      //  public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal UnitPrice {
            get
            {
                return this.unitPrice;
            }
            set
            {
                this.unitPrice = value;
               
            } }
        public decimal TotalPrice { get; set; }
        public Item ProductName { get; set; }
    }
}
