﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Talha Gedik

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Talha";
            musteri1.Soyadi = "Gedik";
            musteri1.TcNo = "12345678910";

            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            //Gerçek müşteri - Tüzel müşteri 
        }
    }
}
