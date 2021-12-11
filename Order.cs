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
        public float CalcTax(int quantity,float price)
        {
            return orderDetail.Quantity * 118 / 100*orderDetail.CalcSubTotal(quantity,price);
        }
        public float CalcTotal(int quantity,float price)
        {
            return orderDetail.CalcSubTotal(quantity, price) + CalcTax(quantity,price);
        }
        public float CalcTotalWeight(int quantity,int weight)
        {
            return orderDetail.CalcWeight(quantity,weight) * orderDetail.Quantity;
        }
    }
}
