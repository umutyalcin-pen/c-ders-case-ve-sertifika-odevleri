using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList sehirler = new ArrayList();
        sehirler.Add("Kocaeli");
        sehirler.Add("Van");
        sehirler.Add("Antalya");
        sehirler.Add("Rize");
        sehirler.Add("Bursa");

        Yazdir(sehirler, "1. Başlangıç");
        sehirler.Sort();
        Yazdir(sehirler, "2. Sıralama");
        sehirler.Insert(0, "Ankara");
        Yazdir(sehirler, "3. Ankara Eklendi");
        sehirler.RemoveAt(3);
        Yazdir(sehirler, "4. Index Silindi");

        if (sehirler.Contains("Van"))
        {
            Console.WriteLine("5. Van Listededir.");
        }
        else
        {
            Console.WriteLine("5. Van Listede Yoktur.");
        }       
        Console.WriteLine("6. Eleman Sayisi: " + sehirler.Count);
        Yazdir(sehirler, "6. Son Durum");
    }

    static void Yazdir(ArrayList liste, string baslik)
    {
        Console.WriteLine("--- " + baslik + " ---");
        foreach (object o in liste)
        {
            Console.WriteLine(o);
        }
    }
}