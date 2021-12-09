using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_Otomasyonu
{
    class OrderDetail
    {
        public int Quantity { get; set; }
        public bool TaxStatus { get; set; }
        private List<Item> items { get; }
        public OrderDetail()
        {
            items = new List<Item>();
        }
        public void AddItem(string description,float price, int shippingWeight)
        {
            items.Add(new Item { Description = description, Price = price, ShippingWeight = shippingWeight });
        }
        public float CalcSubTotal(int quantity,float price)
        {
            this.Quantity = quantity;
            return price * Quantity;  
        }
        public float CalcWeight(int quantity,int weight)
        {
            this.Quantity = quantity;
            return weight * Quantity;
        }
        public List<Item> ListItem()
        {
            return items;
        }
    }
}
