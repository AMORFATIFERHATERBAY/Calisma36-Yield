using System;
using System.Collections;
using System.Collections.Generic;

namespace Calisma36_Yield
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            BasitIterasyon b = new BasitIterasyon();

            foreach (int sayi in b)
            {
                Console.WriteLine(sayi + " ");
            }

            Console.WriteLine();

            AdimSayici adimci = new AdimSayici();
            adimci.AdimSayisi = 3;
            adimci.Maksimum = 98;

            foreach (int sayi in adimci)
                Console.Write(sayi + " ");

            Console.WriteLine();

            adimci.AdimSayisi = 5;
            adimci.Maksimum = 116;

            foreach (int sayi in adimci)
                Console.Write(sayi + " ");
                
            Console.WriteLine();


        }
    }
}
