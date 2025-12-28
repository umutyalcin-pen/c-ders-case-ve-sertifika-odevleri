using System; 

namespace CSharpLearning 
{
    class Program // Sınıf tanımı
    {
       static void Main(string[] args) // Programın başladığı ana metot
       {
        
        // colors[0] = 1. eleman
        // colors[1] = 2. eleman
        // colors[2] = 3. eleman
        // colors[3] = 4. eleman
        string[] colors = new string[4];
        
    
        // Her elemana indeks numarası ile erişip değer atıyoruz
        colors[0] = "Kırmızı";  // 1. eleman (indeks 0)
        colors[1] = "Yeşil";    // 2. eleman (indeks 1)
        colors[2] = "Mavi";     // 3. eleman (indeks 2)
        colors[3] = "Sarı";     // 4. eleman (indeks 3)

        // colors[2] → 3. elemanı (indeks 2) ekrana yazdır → "Mavi"
        Console.WriteLine(colors[2]);

        // Programın kapanmaması için bekle
        Console.Read();
       }
    }
}
