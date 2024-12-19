using System.Threading.Channels;

namespace Konu13Kapsulleme
{
    public class Bolum
    {
        private string BolumAdi; // kapsülleme yapacığımız değişken // accesor - getter
        public string GetBolumAdi() // geri string tipinde değer döndüren metot
        {
            return BolumAdi;
        }
        //mutator - setter
        public bool SetBolumAdi(string a)
        {
            if (a == "Yazılım Uzmanlığı")
            {
                BolumAdi = a;
                return true;
            }
            else
            {
                Console.WriteLine(a + "Bölüm eğitimi kurumumuzda verilmemektedir");
                return false;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kapsülleme, Encaptulation!");
            Console.WriteLine("Nesne yönelimli programlamada kapsülleme eylemi verinin veya metodun başka yerden görünmeyecek biçimde üstün sınıf içinde örtülmesidir");

            Bolum bolum = new Bolum();
            Console.WriteLine("Seçtiğiniz Bölüm Adı:");
            var secilen = Console.ReadLine();
            var sonuc = bolum.SetBolumAdi(secilen);
            if (sonuc == true)
            {
                Console.WriteLine(bolum.GetBolumAdi() + " bölüm kaydınız yapılmıştır");// dışarıdan yollanan veriyi çağırıyoruz
            }

        }
    }
    //Property Kullanarak Kapsülleme İşlemi
    class Fakulte
    {
        private string bolum;
        public string Bolum
        { 
            get
            {
            return bolum;
            }
            set
            {
            bolum = value;
            }
        }
    }
}
