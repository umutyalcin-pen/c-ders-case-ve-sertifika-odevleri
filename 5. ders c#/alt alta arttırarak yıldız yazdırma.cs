    using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args)
       {
       
        // Dış döngü: Satırları kontrol eder (5 satır olacak)
        // i = 1, 2, 3, 4, 5 → Her i değeri bir satırı temsil eder
        for (int i = 1; i <= 5; i++)
        {
            
            // j, 1'den i'ye kadar döner
            // i=1 iken j: 1         → 1 yıldız
            // i=2 iken j: 1,2       → 2 yıldız
            // i=3 iken j: 1,2,3     → 3 yıldız
            // i=4 iken j: 1,2,3,4   → 4 yıldız
            // i=5 iken j: 1,2,3,4,5 → 5 yıldız
            for(int j = 1; j <= i; j++)
            {

                // Yıldızlar yan yana dizilir
                Console.Write("*");
            }
            
            // Console.WriteLine() → Boş satır, iç döngü bittikten sonra alt satıra geç
            // Her satır tamamlandığında bir alt satıra geçiyoruz
            Console.WriteLine();
        }
        
        // Programın hemen kapanmaması için bir tuşa basılmasını bekler
        Console.Read();
       }
    }
}
