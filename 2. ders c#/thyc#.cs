using System;

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args) 
       {
         // Ekrana başlık yazdırıyoruz
         Console.WriteLine("***** Türk Hava Yolları Yolcu Bilgisi ******");
         Console.WriteLine(); // Boş satır bıraktık

        
         // Burada 4 tane string değişken tanımlıyoruz 
         string yolcuAdi, yolcuSoyadi, yolcununSehri, yolcununKimlikNumarasi;

         
         Console.Write("Yolcu Adı: ");
         yolcuAdi = Console.ReadLine(); // Kullanıcının girdiği ad 'yolcuAdi' değişkenine kaydedilir

         Console.Write("Yolcu Soyadı: ");
         yolcuSoyadi = Console.ReadLine(); // Soyad kaydedilir

         Console.Write("Yolcu Şehir: ");
         yolcununSehri = Console.ReadLine(); // Şehir kaydedilir

         Console.Write("Yolcu Kimlik Numarası: ");
         yolcununKimlikNumarasi = Console.ReadLine(); // TC Kimlik No kaydedilir

         Console.WriteLine("--------------------------");
         
      
         // Metinleri ve değişkenleri + ile birleştiriyoruz
         // " " → Boşluk karakteri eklemek için kullanılır
         Console.WriteLine("Yolcu TC Kimlik No: " + yolcununKimlikNumarasi);
         Console.WriteLine("Yolcunun İsim ve Soyismi: " + yolcuAdi + " " + yolcuSoyadi);
         Console.WriteLine("Yolcunun Yaşadığı Şehir: " + yolcununSehri);
       }
    }
}
