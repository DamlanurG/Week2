using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DamlaNurGuney.Sipay.Hafta1
{ //gelen para birimi değerini ToFormattedPrice() metodu ile para birimi formatında oluşturması için metod oluşturuldu.
    public static class extension_Class
    {
        public static decimal price ToFormattedPrice(this decimal amount)
        {
            return amount.ToString("#,##0.00");
        }

        decimal amount = 99999999;

        string moneyFormat = Amount.ToFormattedPrice();

        public global::System.Decimal Amount { get => amount; set => amount = value; }
    }
