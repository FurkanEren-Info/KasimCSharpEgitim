using System.Drawing;
using System.Net.WebSockets;
using System.Text;

namespace Konu08SiniflarClasses
{   class Ev
    {
        internal string sokakAdi; // internal = erişim belirteci
        internal int kapiNo;
        string mahalle; 
    } 
    /*
        Erişim belirteçleri:
        sınıflar ve sınıf öğelerine erişimi kısıtlamak için kullanılır.
        Public    : Erişim kısıtı yoktur her yerden erişebilir
        Protected : Ait olduğu sınıftan ve o sınıftan türetilen sınıftan erişebilir
        internal  : Etkin projeye ait sınıftlardan erişilebilir
        private   : yanlız bulunduğu sınıftan erişilebilir
        
        1 öğee sadece 1 erişim belirteci alablir!
        namespace erişim belirteci almaz public tir
    */
    public class deneme // public - her yerden erişilebilen class
    {
        public string urunAdi = "klavye"; // public - her yerden erişilebilen değişken
        protected class test
        {
            string urunAdi; // erişim belirteci vermezsek varsayılan private olur
        }
    }        
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar - Classes!");

            Ev ev = new Ev(); //yukaridaki ev sınıfından ev isminde bir somut nesne oluşturduk
            ev.sokakAdi = "papatya sokak"; // erişim belirteci tanımlayıp ev sınıfındaki değişkenlere veri atayabildik
            ev.kapiNo = 18;
            // ev.mahlle = // erişim belirteci vermediğimiz için gelmiyor
            Console.WriteLine("Sokak adı : " + ev.sokakAdi);
            Console.WriteLine("Kapı numarası : " + ev.kapiNo);

            Console.WriteLine();

            Ev yazlik = new Ev();
            yazlik.sokakAdi = "Deniz sk.";
            yazlik.kapiNo = 1;

            Console.WriteLine("yazlik sokak Adı: " + yazlik.sokakAdi);
            Console.WriteLine("yazlik kapı No: " + yazlik.kapiNo);

            Console.WriteLine();

            Ev koyEvi = new()// Ev sınıfından bu şekilde de nesne oluşturabiliriz
            {
                kapiNo = 1,
                sokakAdi = "Yeşil Bahçe Sokak"

            };
            Console.WriteLine("koyEvi \n Bilgileri : ");
            Console.WriteLine(koyEvi.sokakAdi);
            Console.WriteLine(koyEvi.kapiNo);

            Kategori kategori = new Kategori();
            kategori.Adi = "Elektornik";

            Console.WriteLine();
            Console.WriteLine("Kategori Adı:");
            Console.WriteLine(kategori.Adi);

            Console.WriteLine();
            Kullanici kullanici = new Kullanici() //Yöntem 1
            {
                Adi = "Furkan",
                KullaniciAdi = "Eren42",
                Sifre = "FurkanEren42",
            };
            Kullanici kullanici2 = new() // yöntem 2
            {
                Adi = "Furkan Eren",
                KullaniciAdi = "Furkan Eren42",
                Sifre = "FurkanEren420",
                Email = "eren@google.com"
            };
            Console.WriteLine();
            Console.WriteLine("kullanici 1 bilgileri :");
            Console.WriteLine($"KullaniciAdi: {kullanici.KullaniciAdi}");



            Console.WriteLine();

            Araba araba = new()
            {
                Id = 1,
                KasaTipi = "SUV",
                Marka = "KATIR",
                Model = "Kırma",
                Renk = "Gri",
                VitesTipi = "Otomatik",
                YakitTipi = "Doğal",

            };
            Console.WriteLine(kullanici.Adi + "Araç Bilgisi:");
            Console.WriteLine($"{araba.Marka} {araba.Model} {araba.Renk} {araba.KasaTipi}  {araba.YakitTipi}");

            Console.WriteLine();

            SiniftaMetotKullanimi siniftaMetotKullanimi = new();
            //sayılar ekrandan alınabilir
            Console.WriteLine("toplama yap: " + siniftaMetotKullanimi.ToplamaYap(10, 8));

            Console.WriteLine("LoginKontrol: " + siniftaMetotKullanimi.LoginKontrol("Admin", "Eren42"));

            Console.WriteLine("Statik Özellik");
            Console.WriteLine(Marka.StatikOzellik);

            Marka.StatikOzellik = "Marka Statik Ozellik";

            Console.WriteLine("Statik Özellik 2");
            Console.WriteLine("Marka.Statik Özellik");
            var marka = new Marka() 
            {
                Id = 1,
                Name = "Monster",
                IsActive = true,

            };
            if  (marka.IsActive) // bu kod marka.IsActive == true konrolü yapar
            {
                 Console.WriteLine("marka: " + marka.Name);
            }
            var urun = new Urun()
            {
                Id = 2,
                Marka = marka,
                Name = "Abra 18 Notebook",
                Description = "Game pc",
                Price = 49900,
            };
            Console.WriteLine("ürün Detayı:");
            Console.WriteLine(urun.Marka.Name + " " + urun.Name);
            Console.WriteLine("Fiyat: " + urun.Price + " TL");
        }
    }

}
