using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args)
       {
        
        Console.Write("Lütfen 1. sayıyı giriniz: ");
        
       
        // int.Parse → String'i tam sayıya (int) çevirir
        // Bu iki işlem tek satırda yapılıyor
        int number1 = int.Parse(Console.ReadLine());

        
        Console.Write("Lütfen 2. sayıyı giriniz: ");
        
        
        int number2 = int.Parse(Console.ReadLine());
        
        
        // '%' operatörü MOD işlemi yapar (bölümden kalanı verir)
        // Örnek: 10 % 3 = 1 (10'u 3'e böldüğümüzde kalan 1'dir)

        int result = number1 % number2;

        
        Console.WriteLine("1. Sayının 2. sayıya bölümünden kalan: " + result);
        
        // Console.Read → Programın hemen kapanmaması için bir tuşa basılmasını bekler
        Console.Read();
       }
    }
}
