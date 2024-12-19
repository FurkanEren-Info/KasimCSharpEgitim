using System.ComponentModel;

namespace Konu09StructYapilari
{
    public struct yapi
    {
        public int sayi;
        public string metin;
        public void Metot()
        {
            Console.WriteLine("Yapı içindeki metot çalıştı!");
        }
    }
    /*             ***Ezberlenmesi lazım***
     * struct - yapıları benzer, sınıfların nesnleri bellekte heap alanında tutulurken yapılarındaki stack alanında tutulur.
     * c# ta değişkenler referans ve deper tipli olarak 2 ye ayrılır.
     * stack de tutulan veriler işi bitince silinir
     * heap te tutulan veriler kendiliğinden silinmez gc ile silinir
     */
    internal class Program
    {
        struct Kimlik
        {
            //değişkenler
            public string Ad;
            public string Soyad;
            public int yas;
            public string dogumYeri;
            public struct Adres
            {
                //property ler
                public int Id { get; set; }
                public string Sehir { get; set; }
                public string Mahalle { get; set; }
                public string AcikAdres { get; set; }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Konu09 Struct-Yapilari!");

            yapi ilkyapi = new yapi();
            ilkyapi.metin = "yapı metni";
            ilkyapi.sayi = 25;
            ilkyapi.Metot();

            Kimlik kimlik = new Kimlik();
            kimlik.Ad = " Furkan";
            kimlik.Soyad = " Eren";
            kimlik.yas = 27;

            Console.WriteLine($"Kişi Bilgileri : \nAd :{ kimlik.Ad}\nSoyad :{kimlik.Soyad}\n");


            Kimlik.Adres adres = new();
            adres.Sehir = "Konya";
            adres.Mahalle = "Özalkent";
            adres.AcikAdres = "Örnek";

            Console.WriteLine(adres.Sehir);
            Console.WriteLine(adres.Mahalle);
            Console.WriteLine(adres.AcikAdres);
        }
    }
}
