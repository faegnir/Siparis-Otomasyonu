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
        public void GetWeight(int shippingWeight)
        {
            this.ShippingWeight = shippingWeight;
        }
        public float GetPriceForQuantity()
        {
            if (this.ShippingWeight >= 30 && this.ShippingWeight <= 50)
                this.Price = this.ShippingWeight * 1.8f;
            else if (this.ShippingWeight > 50)
                this.Price = this.ShippingWeight * 1.3f;
            else
                this.Price = this.ShippingWeight;

            return this.Price;
        }
       
        public override string ToString()
        {
            return this.Description + " " +this.ShippingWeight + " " + this.Price;
        }
    }
}
