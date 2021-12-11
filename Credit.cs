using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipariş_Otomasyonu
{
    class Credit: Payment
    {
        public string Number { get; set; }
        public string CardName { get; set; }
        public string ExpDate { get; set; }
        public int Cvv { get; set; }

        public void Authorized(string cardName, string expDate, string number, int cvv)
        {

        }
    }
}
