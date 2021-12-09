using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_Otomasyonu
{
    class Check : Payment
    {
        public string Name { get; set; }
        public int BankID { get; set; }

        public void Authorized()
        {

        }
    }
}
