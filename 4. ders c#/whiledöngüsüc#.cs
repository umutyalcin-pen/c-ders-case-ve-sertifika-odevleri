using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args) 
       {
        // 'i' döngüde kaç kez dönüldüğünü takip eden sayaç değişkeni
        // while döngüsünde sayaç döngü DIŞINDA tanımlanmalı
        int i = 1;

        
        // i <= 10 → i, 10'dan küçük veya eşit olduğu sürece döngü devam eder
        while (i <= 10)
        {
            // Her turda i'nin değerini ekrana yazdır
            Console.WriteLine(i);
            
            // i++ → i'yi 1 arttır (i = i + 1 ile aynı)
            // Bu satır olmazsa SONSUZ DÖNGÜ oluşur! (i hep 1 kalır)
            i++;
        }
        // Döngü bittiğinde i = 11 olur (çünkü 11 <= 10? YANLIŞ)
       }
    }
}
