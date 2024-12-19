﻿namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Sınıfı");
            string degisken;
            char karekter;
            string metin = "String yan yana dizi formatında char yapısıdır.";
            //Ornek();
            StringMetotlari();

        }
        static void Ornek()
        {
            string birMetin = "Ankara başkenttir";
            String birSayi = "123456789";
            System.String birTarih = "28-10-2023";
            string s = "Barış Manço";
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine($"s[{i}] {s[i]}"); // i nin değerini vs s değişkeninde i. indexteki değeri ekrana yaz
            }
            foreach (char c in s)
            {
                Console.WriteLine(c); // s değişkenindeki her karekteri tek tek ekrana yaz
            }
            Console.WriteLine("birMetin veri tipi : " + birMetin.GetType()); // GetType metodu bize ilgili değişkenin veri tipini getirir.
            Console.WriteLine("birSayi veri tipi : " + birSayi.GetType());
            Console.WriteLine("birTarih veri tipi : " + birTarih.GetType());
        }



        static void StringMetotlari()
        {
            string metin = "Stringin birçok metodu vardır";
            Console.WriteLine("metin: " + metin);
            Console.WriteLine("metinin karekter sayısı : " + metin.Length);
            var klon = metin.Clone();
            Console.WriteLine("Metin klonu : " + klon);
            metin = "My name is Ali";
            Console.WriteLine("metin: " + metin);
            Console.WriteLine("metin.EndsWith(\"r\")" + metin.EndsWith("r"));
            Console.WriteLine("metin.EndsWith(\"i\")" + metin.EndsWith("i"));
            Console.WriteLine("metin.StartsWith(\"S\")" + metin.StartsWith("S"));
            Console.WriteLine("metin.StartsWith(\"M\")" + metin.StartsWith("M"));
            Console.WriteLine("metin.IndexOf(\"i\")" + metin.IndexOf("i"));
            Console.WriteLine("metin.IndexOf(\"name\")" + metin.IndexOf("name"));
            Console.WriteLine("metin.IndexOf(\"birçok\")" + metin.IndexOf("birçok"));// IndexOf metodu aranan kelimeyi bulamazsa -1 değeri döndürür
            Console.WriteLine("metin.LastIndexOf(\"i\")" + metin.LastIndexOf("i"));// i en son hangi indexte geçiyor
            Console.WriteLine("metin.Insert-ekleme: " + metin.Insert(0,"Merhaba "));
            Console.WriteLine("metin: " + metin);
            Console.WriteLine("metin.Substring:" + metin.Substring(2));
            Console.WriteLine("metin.Substring(2, 5):" + metin.Substring(2, 5));
            Console.WriteLine("metin.ToLower(): " + metin.ToLower());//metini küçük harfe çevir
            Console.WriteLine("metin.ToUpper(): " + metin.ToUpper());// metini büyük harfe çevir
            Console.WriteLine("metin.Replace(): " + metin.ToLower().Replace(" ","-"));
            Console.WriteLine("metin.Remove(2, 5): " + metin.Remove(2, 5)); //silme kaldırma 

            string sehirler = "İstanbul, Ankara, İzmir, Muş, Çankırı";
            Console.WriteLine(sehirler);
            string[] sehirlerArray = sehirler.Split(","); // şehirler değişkenindeki veriyi aralarındaki , e göre parçala ve sehirlerArray string dizisine ekle
            Console.WriteLine(sehirlerArray[2]); // dizideki 2. indexteki elemanı yaz

            foreach (string s in sehirlerArray) 
                Console.WriteLine(s);



        }


    }
}