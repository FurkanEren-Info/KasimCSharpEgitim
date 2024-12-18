using System;

namespace Konu05Metotlar
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Metotlar!");
                //    Console.WriteLine();
                //    ToplamaYap(); //Metodu yazdıktan sonra burada çagırmazsak çalışmaz

                //    Console.WriteLine("Bir sayı giriniz");
                //    var sayi1 = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine("Bir sayı daha giriniz");
                //    var sayi2 = Convert.ToInt32(Console.ReadLine());
                //    ToplamaYap2(sayi1, sayi2);

                //    Console.WriteLine();
                //    var geridonendeger = ToplamaTap2(sayi1 , sayi2, 10); // ToplamaTap2 metodunu çağırıyoruz
                //    Console.WriteLine("geri dönen değer: " + geridonendeger); 


                //}
                //static void ToplamaYap()
                //{
                //    Console.WriteLine(10 + 8);
                //}
                //static void ToplamaYap2(int sayi1, int sayi2)// int sayi1, int sayi2 parametredir, dışarıdan veri kabulünü sağlar
                //{
                //    Console.WriteLine("Sonuç : " + (sayi1 + sayi2));
            }

                // Aşağıdaki metot geriye int türünde bir veri döndürür
                //static int ToplamaTap2(int sayi1, int sayi2, int sayi3) //metod imzası (isim + parametreler)
                //{
                //    Console.WriteLine();
                //    return sayi1+ sayi2 + sayi3;// returun ile geriye sayıların toplamını döndürdük
                //}
                // Kullanıcı giriş kontrolünü başlat
            LoginKontrol();
        }

        // Kullanıcı girişini kontrol eden metod
        static void LoginKontrol()
        {
            Console.WriteLine("Email Adresinizi Giriniz: ");
            var email = Console.ReadLine(); // E-posta alınır
            Console.WriteLine("Lütfen Şifrenizi Giriniz: ");
            var sifre = Console.ReadLine(); // Şifre alınır

            // Kullanıcı girişi sonucu doğrulama işlemi
            var sonuc = UyeGirisi(email, sifre);
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrEmpty(sifre))
            {
                Console.WriteLine("Email Ve Şifre Boş Bırakılamaz");
            }
            else if (sonuc == true)
            {
                
            }

            // Giriş sonucuna göre mesaj gösterme
            if (sonuc)
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız");
            }
        }

        // Kullanıcı giriş bilgilerini doğrulayan metod
        static bool UyeGirisi(string email, string sifre)
        {
            // Sistemdeki kayıtlı e-posta ve şifre ile karşılaştırma
            if (email == "eren@gmail.com" && sifre == "eren123")
            {
                return true; // E-posta ve şifre doğruysa giriş başarılı
            }
            return false; // E-posta ve şifre yanlışsa giriş başarısız
        }
    }
}
