using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args)
       {
        // --- 1. KULLANICIDAN SAYI ALMA ---
        Console.Write("Sayıyı giriniz: ");
        
        // Kullanıcının girdiği sayıyı int'e çevirip number'a kaydediyoruz
        int number = int.Parse(Console.ReadLine());
        
        // Basamak değerlerini tutacak değişkenler
        int ones, tens, hundreds;

       
        
        // Birler basamağı: Sayının 10'a bölümünden kalan
        ones = number % 10;
        
        // Onlar basamağı: Önce 10'a böl, sonra 10'a bölümünden kalanı al
        tens = (number / 10) % 10;
        
        // Yüzler basamağı: Önce 100'e böl, sonra 10'a bölümünden kalanı al
        hundreds = (number / 100) % 10;

        // --- 3. BASAMAKLARI EKRANA YAZDIRMA ---
        Console.WriteLine(ones + "-" + tens + "-" + hundreds);

        // --- 4. BASAMAKLARIN TOPLAMINI HESAPLAMA ---
        int sum = ones + tens + hundreds;

        // Toplamı ekrana yazdır
        Console.WriteLine("Basamaklar toplamı: " + sum);

        // Programın hemen kapanmaması için bekle
        Console.Read();
       }
    }
}
