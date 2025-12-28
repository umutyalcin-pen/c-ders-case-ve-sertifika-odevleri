using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args) 
       {
       
        // n = 5 → Baklava diliminin maksimum genişliği
        int n = 5;
        
        // Dış döngü: Satırları kontrol eder (i: 1,2,3,4,5)
        for(int i = 1; i <= n; i++)
        {
            // 1. İç döngü: Boşlukları yazar (sola hizalama için)
            // Satır numarası arttıkça boşluk azalır
            // i=1 → 4 boşluk, i=2 → 3 boşluk, ... i=5 → 0 boşluk
            for(int j = n - i; j > 0; j--)
            {
                Console.Write(" "); // Boşluk karakteri
            }
            
            // 2. İç döngü: Yıldızları yazar
            // Her satırda 2*i-1 adet yıldız olur
            // i=1 → 1 yıldız, i=2 → 3 yıldız, i=3 → 5 yıldız, i=4 → 7 yıldız, i=5 → 9 yıldız
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Satır bitti, alt satıra geç
        }
        
        // --- ALT KISIM (AZALAN YILDIZLAR) ---
        for(int i = n - 1; i >= 1; i--)
        {
            // 1. İç döngü: Boşlukları yazar
            for(int j = n - i; j > 0; j--)
            {
                Console.Write(" ");
            }
            
            // 2. İç döngü: Yıldızları yazar
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // Satır bitti, alt satıra geç
        }       
        Console.Read(); // Programın kapanmaması için bekle
       }
    }
}
