using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<String> coffe = new List<String>(); //Önce bir liste oluşturuyoruz.

        // Kullanıcıdan 5 adet kahve ismi alınacağı için for döngüsü kullanıyoruz.

        for (int i = 0; i<5; i++)
        {
            Console.WriteLine("Kahve ismini giriniz: ");
            string kahve = Console.ReadLine();
            coffe.Add(kahve);
        }
        Console.WriteLine("Kahve isimleri:");
        foreach (string kahve in coffe)
        {
            Console.WriteLine(kahve);

        }
    }
}