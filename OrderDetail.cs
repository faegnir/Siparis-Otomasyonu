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
        private List<Item> Items { get; set; }
        public OrderDetail()
        {
            this.Items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
            this.Items.ForEach(Console.WriteLine);
        }
        public float CalcSubTotal(int quantity,Item item)
        {
            this.Quantity = quantity;
            return item.Price * Quantity;
            
        }
        public float CalcWeight(int quantity,Item item)
        {
            this.Quantity = quantity;
            return item.ShippingWeight * Quantity;
        }
    }
}
