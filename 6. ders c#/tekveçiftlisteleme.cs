using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args) 
       {
        // 5 elemanlı bir tam sayı dizisi
        int[] numbers = { 21, 42, 33, 54, 55};
        
        Console.WriteLine("Çift sayılar");
        Console.WriteLine();

        // Diziyi gez ve çift sayıları yazdır
        for(int i = 0; i < numbers.Length; i++)
        {
            // Çift sayı kontrolü:
            // % 2 → Sayının 2'ye bölümünden kalan
            // == 0 → Kalan 0 ise, sayı çifttir
            // Örnek: 42 % 2 = 0 (çift), 21 % 2 = 1 (tek)
            if(numbers[i] % 2 == 0)
            {
                Console.WriteLine(numbers[i]);
            }     
        }
        
        // --- 3. TEK SAYILARI BULMA ---
        Console.WriteLine("Tek sayılar");
        Console.WriteLine();

        // Diziyi gez ve tek sayıları yazdır
        for(int i = 0; i < numbers.Length; i++)
        {
            // Tek sayı kontrolü:
            // != 0 → Kalan 0'a eşit DEĞİLSE, sayı tektir
            // Örnek: 21 % 2 = 1 (1 != 0, yani tek)
            if(numbers[i] % 2 != 0)
            {
                Console.WriteLine(numbers[i]);
            }
        }
       }
    }
}
