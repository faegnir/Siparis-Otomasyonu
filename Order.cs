using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_Otomasyonu
{
    class Order
    {
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public OrderDetail orderDetail;

        public Order(OrderDetail orderDetail)
        {
            this.orderDetail = orderDetail;
        }
        public void CalcTax()
        {
            
        }
        public void CalcTotal()
        {

        }
        public void CalcTotalWeight()
        {

        }
    }
}
