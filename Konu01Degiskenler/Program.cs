namespace Konu01Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();//çift slash yorum satırı
            //içi boş olursa ekrana boş satır oluşturuyor
            Console.WriteLine("Merhaba, Dünya");
            Console.WriteLine("Benim adım Furkan");
            Console.WriteLine("Değişkenler");// bu projeyi çalıştırmak için üst menüden play tuşunun yanından projeyi seçtik

            Console.WriteLine("Değişken tanımlama - Tam sayılar");//Değişken tanımlama - Tam sayılar
            byte plakakodu = 34;
            short kisa = 123;
            int tamsayi = 1800;
            long uzunsayi = 123456;
            plakakodu = 18;
            Console.WriteLine("plaka kodu: " + plakakodu);

            //Kesirli Sayilar
            Console.WriteLine("Kesirli Sayılar");
            float kesirliSayi = 4.5f;
            double kesirlidouble = 4.5;
            decimal urunFiyati = 5500;

            urunFiyati = 6600;

            Console.WriteLine("Ürün Fiyatı : " + urunFiyati);

            //Karekter
            char karakter = 'c'; //kalvyediki tüm karekterleri taşıyabilir char veri tipi sadece 1 karekter alır ve tek tırnak içinde değer alır.

            //string veri tipi
            string metin = "klavyedeki tüm karekterleri yan yana yazılmış olarak taşıyabilir";

            Console.WriteLine();
            Console.WriteLine("metin: " + metin);

            // boolean veri tipi
            bool islemSonucu = false; // işlem başarılı mı başarısızmı 2 deger alabilir true - false

            Console.WriteLine("islemSonucu {0} ikinci parametre : {1}" , islemSonucu, karakter);

            metin = "yeni metin";
            Console.WriteLine($"işlemSonucu {islemSonucu} Metin yazısı : {metin}");// $ değişkenleri metin içerisinde bir önceki gibi parametreli göndermek yerine direk kullanabilmek için tırnak başına $ ekliyoruz

            //C# ta Sabit Tanımalama
            const int kdvMiktarı = 18;
            const double dolarKuru = 34.18;
            const double euroKuru = 37.18;
            //kdvMiktari = 20; sabitlerin değeri sonradan değiştirilmez!
            Console.WriteLine(kdvMiktarı);
        }
    }
}
