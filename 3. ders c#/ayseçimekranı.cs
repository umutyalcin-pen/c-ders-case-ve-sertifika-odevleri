using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args) 
       {
      
        Console.Write("Lütfen ay girişi yapınız: ");
        
        
        // int.Parse → String'i tam sayıya çevirir
        int monthNumber = int.Parse(Console.ReadLine());

       
        // switch: Bir değişkenin değerine göre farklı kodları çalıştırır
        // if-else if-else yapısına alternatif, daha düzenli bir yaklaşımdır
        // Parantez içindeki değişken (monthNumber) kontrol edilir
        switch (monthNumber)
        {
            // case 1: monthNumber 1'e eşitse bu satır çalışır
            // break: Bu case'den çıkıp switch bloğunu sonlandırır
            case 1: Console.Write("Ocak"); break;
            case 2: Console.Write("Şubat"); break;
            case 3: Console.Write("Mart"); break;
            case 4: Console.Write("Nisan"); break;
            case 5: Console.Write("Mayıs"); break;
            case 6: Console.Write("Haziran"); break;
            case 7: Console.Write("Temmuz"); break;
            case 8: Console.Write("Ağustos"); break;
            case 9: Console.Write("Eylül"); break;
            case 10: Console.Write("Ekim"); break;
            case 11: Console.Write("Kasım"); break;
            case 12: Console.Write("Aralık"); break;
            
            // default: Hiçbir case eşleşmezse çalışır (else gibi)
            // Örneğin kullanıcı 13 veya 0 girerse burası çalışır
            default: Console.Write("Geçersiz ay numarası!"); break;
        }
       }
    }
}
