using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager   //KrediManagerdaki kurallar buralara implement edilir. Uygulanır.
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi ödeme planı hesaplandı.");
        }
    }
}
