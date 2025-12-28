using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args) 
       {
        // --- 1. ÜST ÜÇGEN (ARTAN YILDIZLAR) ---
        // Dış döngü: 5 satır (i: 1,2,3,4,5)
        for (int i = 1; i <= 5; i++)
        {
            // İç döngü: i kadar yıldız yaz
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*"); // Yıldızı yaz, alt satıra geçme
            }
            Console.WriteLine(); // Satır bitti, alt satıra geç
        }
        
        // --- 2. ALT ÜÇGEN (AZALAN YILDIZLAR) ---
        // k: 4'ten 1'e doğru azalır (ters üçgen)
        for (int k = 4; k >= 1; k--)
        {
            // İç döngü: k kadar yıldız yaz
            for (int m = 1; m <= k; m++)
            {
                Console.Write("*"); // Yıldızı yaz
            }
            Console.WriteLine(); // Satır bitti, alt satıra geç
        }       
        Console.Read(); // Programın kapanmaması için bekle
       }
    }
}
