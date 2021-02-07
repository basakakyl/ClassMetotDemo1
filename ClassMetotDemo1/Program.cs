using System;

namespace ClassMetotDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Elif";
            musteri1.Soyad = "Balık";
            musteri1.TelefonNumarasi = "5055055858";
            musteri1.Maas = 2100;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Pamuk";
            musteri2.Soyad = "Bal";
            musteri2.TelefonNumarasi = "5065325437";
            musteri2.Maas = 4500;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Oscar";
            musteri3.Soyad = "Kemirgenoğlu";
            musteri3.TelefonNumarasi = "05055433223";
            musteri3.Maas = 22000;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            
           
            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("------ Hoş geldiniz ------");
            Console.WriteLine("------ Müşteriler Listeleniyor ------");
            musteriManager.MusteriList(musteriler);
            Console.WriteLine("------ Lütfen 'Enter' tuşuna basın ve müşteriyi eklediğimi görün. ------");
            Console.ReadKey();
            Console.WriteLine("------ Müşteri Ekleniyor ------");
            musteriManager.Ekle(musteri1);
            Console.WriteLine("------ Lütfen 'Enter' tuşuna basın ve müşteriyi kaldırdığımı görün. ------");
             Console.ReadKey();
            Console.WriteLine("------ Müşteri Kaldırılıyor ------");
            musteriManager.Kaldir(musteri2);
            



        }
    }
}
