using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_Otomasyonu
{
    class Item
    {
        public float ShippingWeight { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        
        public void GetPriceForQuantity(float price)
        {
            this.Price = price;
        }
        public void GetWeight(int shippingWeight)
        {
            this.ShippingWeight = shippingWeight;
        }     
    }
}
