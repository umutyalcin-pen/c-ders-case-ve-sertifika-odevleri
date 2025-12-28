using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args) 
       {
        /
        //
        // i = 1      → Başlangıç: Sayaç 1'den başlar
        // i <= 10    → Koşul: i, 10'dan küçük veya eşit olduğu sürece devam et
        // i++        → Artış: Her turda i'yi 1 arttır
        for(int i = 1; i <= 10; i++)
        {
            // Bu satır 10 kez çalışır (i: 1,2,3,4,5,6,7,8,9,10)
            // Her seferinde 10 yıldız (*) yazdırır
            Console.WriteLine("**********");
        }
        
        // Programın hemen kapanmaması için bir tuşa basılmasını bekler
        Console.Read();
       }
    }
}
