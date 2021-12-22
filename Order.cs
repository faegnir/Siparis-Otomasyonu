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

        public float Tax { get; set; }
        public float Total { get; set; }
        public float Weight { get; set; }
        public Customer Customer { get; set; }
        public Order(OrderDetail orderDetail)
        {
            this.orderDetail = orderDetail;
        }
        public float CalcTax(int quantity,float price)
        {
            //KDV tutarını hesaplar
            return ((orderDetail.CalcSubTotal(quantity, price) * 118 / 100 ) - orderDetail.CalcSubTotal(quantity, price));
        }
        public float CalcTotal(int quantity,float price)
        {
            return (orderDetail.CalcSubTotal(quantity, price) * 118 / 100);
        }
        public float CalcTotalWeight(int quantity,int weight)
        {
            return  orderDetail.CalcWeight(quantity, weight);
        }
    }
}
