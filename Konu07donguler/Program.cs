namespace Konu07donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Konu 07 Döngüler");
            
            Console.WriteLine("1-For Döngüler");
            for (int i = 0; i < 10; i++) // döngü tanımlaması
            {
                Console.WriteLine("i nin değeri : " + i); // her döndüğündeki o anki değeri ekrana yaz
            }

            Console.WriteLine();
            Console.WriteLine("2-while Döngüsü");
            int j = 0; //Değişken döngü dışında tanımlar
            while (j < 10) // şartımız - j 10 dan küçük oldugu sürece dön
            {
                Console.WriteLine("j nin değeri : " + j); //j nin değerini yazdır
                j++; //döngü her çalıştıgında j yi 1 artırır ki sonsuz döngüye girmesin
            }

            Console.WriteLine();
            Console.WriteLine("3-Do While Döngüsü");
            int toplamUrun = 0; // değişken tanımladık
            do
            {
                Console.WriteLine("Ürünlerimiz");
                Console.WriteLine("Elektoronik kateğorisinde uygun fiyatlar");
                Console.WriteLine("toplamın değeri : " + toplamUrun);
                ;
            }
            while (toplamUrun < 0);

            Console.WriteLine();
            Console.WriteLine("4-Foreach Döngüsü");
            string[] kategoriler = { "Elektornik", "Bilgisayar", "Telefon", "Aksesuar", "Mobilya" };
            foreach (var kategori in kategoriler) // dizi formatındaki yapılarda kullanılır
            {
                Console.WriteLine("kategori adı : " + kategori); // dizideki her bir elemanda dönülür
            }
            Console.WriteLine();

            Console.WriteLine("Kategorilerin iç içe kaullanımı");

            string[] urunler = { "ürün1", "ürün2", "ürün3" };

            foreach (var kategori in kategoriler) // dizi formatındaki yapılarda kullanılır
            {
                Console.WriteLine("kategori adı : " + kategori);
                foreach (var urun in urunler)
                {
                    Console.WriteLine("\tÜrün adı : " + urun);
                }
            }


















        }
    }
}
 