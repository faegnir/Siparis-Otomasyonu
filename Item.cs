using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_Otomasyonu
{
    class Item
    {
        public int ShippingWeight { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public void GetWeight(int shippingWeight)
        {
            this.ShippingWeight = shippingWeight;
        }
        public void GetPriceForQuantity(float price)
        {
            this.Price = price;
        }
       
        public override string ToString()
        {
            return this.Description + " " +this.ShippingWeight + " " + this.Price;
        }
    }
}
