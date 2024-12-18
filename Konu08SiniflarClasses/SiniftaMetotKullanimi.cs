using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu08SiniflarClasses
{
    internal class SiniftaMetotKullanimi
    {
        string kurucuMetot;
        //ctor tab kısayolla constructor oluşturma
        public SiniftaMetotKullanimi()
        {
            //burası sınıfın kurucu metodu
            kurucuMetot = "kurucu metotlar sınıflardan oluşturulan her nesne örneğinde ilk çalışan metotlardır. Geri dönüş tipleri olmaz. ";
            Console.WriteLine(kurucuMetot);
            Console.WriteLine();
        }

        public bool LoginKontrol(string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi == "Admin" && sifre == "Eren42")
            {
                return true;
            }
            return false;

        }  
        

        public int ToplamaYap(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

    }
}







