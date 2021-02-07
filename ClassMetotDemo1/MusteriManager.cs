using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo1
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " adlı müşteri başarıyla eklendi\n");
            Console.ReadKey();
        }

        public void Kaldir(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " adlı müşteri başarıyla kaldırıldı\n");
            Console.ReadKey();
        }

        public void MusteriList(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine("Müşterinin bilgileri= " + musteri.Ad + " " + musteri.Soyad);
                Console.WriteLine("Müşterinin maaşı= " + musteri.Maas);
                Console.WriteLine("Müşterinin telefon numarası= " + musteri.TelefonNumarasi);

            }
        }

    }
}