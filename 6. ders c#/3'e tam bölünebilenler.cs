using System; 

namespace CSharpLearning 
{
    class Program // Sınıf tanımı
    {
       static void Main(string[] args) 
       {
        int[] numbers = {4, 85, 96, 74, 488, 530};
        
       
        // numbers.Length → Dizideki eleman sayısını verir (6)
        // i < numbers.Length → i, 0'dan 5'e kadar döner (toplam 6 eleman)
        for(int i = 0; i < numbers.Length; i++)
        {
           
            // numbers[i] % 3 == 0 → Sayı 3'e tam bölünüyor mu?
            // % (mod) → Bölümden kalanı verir
            // == 0 → Kalan 0 ise, sayı 3'ün katıdır
            if (numbers[i] % 3 == 0)
            {
                // 3'e tam bölünen sayıları yazdır
                Console.WriteLine(numbers[i]);
            }
        }
        
        // Programın kapanmaması için bekle
        Console.Read();
       }
    }
}
