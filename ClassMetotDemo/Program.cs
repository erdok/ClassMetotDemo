using System;

namespace ClassMetotDemo
{
    class Program //
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine("...");

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.TC = 14587495238;
            musteri1.MusteriAdi = "Lagari";
            musteri1.MusteriSoyadi = "Hasan Çelebi";
            musteri1.Email = "laghascel@gmail.com";
            musteri1.sifre = "12991453lhc";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1;
            musteri2.TC = 14587495288;
            musteri2.MusteriAdi = "Hazerfan";
            musteri2.MusteriSoyadi = "Ahmet Çelebi";
            musteri2.Email = "hazahcel@gmail.com";
            musteri2.sifre = "12991453hac";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);


            

        }
    }
}
