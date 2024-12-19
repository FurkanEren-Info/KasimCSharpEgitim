using System.ComponentModel;
using System.Timers;

namespace Konu11Enumlar
{
    internal class Program
    {
        enum Aylar : byte
        {
            Ocak, Şubat, Mart
        }
        enum SiparisDurumu
        {
            Hazırlanıyor,Hazırlandı,KargoBekleniyor,Kargolandı
        }
        enum Meyveler : int // Meyveler int tipinde numaralnsın
        {
            Elma = 3, Armut = 7, Cilek = 1 // elemanlara sıra numarası verebiliriz
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enumlar");
            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Cilek;
            Console.WriteLine($"{Meyveler.Armut} = {a} - {Meyveler.Elma} = {b}");
            SiparisKontrol(3);
        }


        static void SiparisKontrol(int siparisDurum)
        {
            if (siparisDurum == 0)
            {
                Console.WriteLine("Sipariş Durumu " + SiparisDurumu.Hazırlanıyor);
            }
            if (siparisDurum == 1)
            {
                Console.WriteLine("Sipariş Durumu " + SiparisDurumu.Hazırlandı);
            }
            if (siparisDurum == 2)
            {
                Console.WriteLine("Sipariş Durumu " + SiparisDurumu.KargoBekleniyor);
            }
            if (siparisDurum == 3)
            {
                Console.WriteLine("Sipariş Durumu " + SiparisDurumu.Kargolandı);
            }
        }

        public enum UserType // uygulamamızdaki kullanıcı tiplerini tutacağımız enum
        {
            [Description("Süper Admin")] // enum özelliklerini açıklama
            SuperAdmin = 1,
            [Description("İşveren")]
            Employer,
            [Description("Çalışan")]
            Employee,
            TestKullanicisi
        
        
        
        
        
        
        
        
        
        }






    }
}
