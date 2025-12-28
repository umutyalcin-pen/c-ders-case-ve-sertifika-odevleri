using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args) 
       {
        // 5 elemanlı boş bir string dizisi oluşturuyoruz
        // Başlangıçta tüm elemanlar null (boş)
        string[] cities = new string[5];

        // --- 2. KULLANICIDAN VERİ ALMA (GİRİŞ DÖNGÜSÜ) ---
        // cities.Length = 5 → i: 0,1,2,3,4
        // Bu döngü 5 kez çalışır ve her seferinde bir şehir ismi alır
        for (int i = 0; i < cities.Length; i++)
        {
            Console.Write("Enter city name: ");
            
            // Kullanıcının girdiğini dizinin i. elemanına kaydet
            // i=0 → cities[0], i=1 → cities[1], ...
            cities[i] = Console.ReadLine();
        }
        Console.WriteLine();
        Console.WriteLine("--------------------");

        
        for (int i = 0; i < cities.Length; i++)
        {
            Console.WriteLine(cities[i]);
        }
       }
    }
}
