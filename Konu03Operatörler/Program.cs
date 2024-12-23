﻿namespace Konu03Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operatörler");
            Console.WriteLine("1-Aritmetik Operatörler");
            int sayi1 = 3;
            int sayi2 = 4;
            int sayi3 = 5;

            Console.WriteLine($"Sayılar : sayi1 : {sayi1} sayi2 : {sayi2} sayi3: {sayi3}");
            Console.WriteLine("sayi1" + sayi1); //string ile sayısal değer toplanırsa .net bunları birleştirir hesaplamaz
            Console.WriteLine("sayi1 + sayi2 : " + (sayi1 + sayi2)); //toplama işlemi yapmak için hesaplanacak değerleri parantez içine alıyoruz
            Console.WriteLine("sayı2 - sayı1 : " + (sayi2 - sayi1));
            Console.WriteLine("sayı2 * sayı1 : " + (sayi2 * sayi1));
            Console.WriteLine("sayı2 / sayı1 : " + (sayi2 / sayi1));
            Console.WriteLine("sayı2 % sayı1 : " + (sayi2 % sayi1));

            //artırım ve azaltım işlemi
            Console.WriteLine("Sayı 2 : " + sayi2);
            sayi2++; // sayı 2 değerini 1 artır
            Console.WriteLine("Sayı 2 : " + sayi2);

            Console.WriteLine("Sayı 3 : " + sayi3);
            sayi3--;
            Console.WriteLine("Sayı 3 : " + sayi3);

            Console.WriteLine();

            Console.WriteLine("Atama Operatörleri : ");
            Console.WriteLine($"Sayılar : sayi1 : {sayi1} sayi2 : {sayi2} sayi3 : {sayi3}");
            Console.WriteLine("sayi1 += sayi2 : " + (sayi1 += sayi2));
            Console.WriteLine("sayi1 -= sayi2 : " + (sayi1 -= sayi2));
            Console.WriteLine("sayi1 *= sayi2 : " + (sayi1 *= sayi2));
            Console.WriteLine("sayi1 /= sayi2 : " + (sayi1 /= sayi2));

            Console.WriteLine("İlişkisel Operatörler");
            Console.WriteLine($"Sayı 1 sayı 2 ye eşit mi? " + (sayi1 == sayi2));
            Console.WriteLine($"Sayı 1 sayı 2 ye eşit değil mi? " + (sayi1 != sayi2));
            Console.WriteLine($"Sayı 1 sayı 2 ye büyük mü? " + (sayi1 > sayi2));
            Console.WriteLine($"Sayı 1 sayı 2 ye küçük mü? " + (sayi1 < sayi2));
            Console.WriteLine($"Sayı 1 sayı 2 ye küçük veya eşitmi ? " + (sayi1 <= sayi2));
            Console.WriteLine($"Sayı 1 sayı 2 ye büyük veya eşit mi? " + (sayi1 >= sayi2));

            Console.WriteLine("ternay operatörü : " + ((sayi1 == sayi2) ? "eşit" : "eşit değil"));

            Console.WriteLine();

            Console.WriteLine("Mantıksal Operatörler");
            Console.WriteLine("And & ve opeatöü");
            Console.WriteLine($"Sayılar : sayi1 : {sayi1} sayi2 : {sayi2} sayi3: {sayi3}");
            Console.WriteLine($"Sayı 1 sayı 2 ye eşitmi?" + ((sayi1 == sayi2) && (sayi2 > sayi3)));

            Console.WriteLine("Or || veya operatörü");
            Console.WriteLine($"Sayı 1 sayı 2 eşitmi? " + ((sayi1 == sayi2) || (sayi2 > sayi3)));



        }
    }
}
