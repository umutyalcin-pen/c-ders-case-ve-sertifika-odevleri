using System; 

namespace CSharpLearning 
{
    class Program
    {
       static void Main(string[] args) 
       {
       
        // 'int' tam sayı tipinde değişken tanımlar
        // 3 sınav notu ve ortalama için değişkenler oluşturuyoruz
        int exam1, exam2, exam3, average;
        
        // 'string' metin tipinde değişken tanımlar
        // Başlangıçta "Hata!" değeri atadık (varsayılan değer)
        // Eğer if-else çalışmazsa bu değer kalır
        string result = "Hata!";

        
        // Convert.ToInt32 → Metni tam sayıya çevirir (örn: "70" → 70)
        Console.Write("Sınav 1: ");
        exam1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Sınav 2: ");
        exam2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Sınav 3: ");
        exam3 = Convert.ToInt32(Console.ReadLine());

        
        // Üç sınavı toplayıp 3'e bölüyoruz
        // Parantez içi önce hesaplanır: (exam1 + exam2 + exam3)
        // Sonra sonuç 3'e bölünür
        // Not: int bölme işlemi ondalıksız sonuç verir (örn: 70, 70.33 değil)
        average = (exam1 + exam2 + exam3) / 3;

        
        if (average >= 50)
        {
            result = "Geçti";
        }
        
        
        else
        {
            result = "Kaldı";
        }

        // --- 5. SONUÇLARI EKRANA YAZDIRMA ---
        // Metin ve değişken + operatörüyle birleştirilir
        Console.WriteLine("Ortalama: " + average);
        Console.WriteLine("Sonuç: " + result);
       }
    }
}
