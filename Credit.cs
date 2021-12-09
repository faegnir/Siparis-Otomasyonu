using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_Otomasyonu
{
    class Credit: Payment
    {
        public int Number { get; set; }
        public string Type { get; set; }
        public DateTime ExpDate { get; set; }

        public void Authorized()
        {

        }
    }
}
