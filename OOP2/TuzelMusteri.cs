using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    //inheritance - miras
    class TuzelMusteri:Musteri  //Tüzel müşteri aynı zamanda müşteridir de. Müşteride olan her şey tüzelde de kabul edilir.
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
