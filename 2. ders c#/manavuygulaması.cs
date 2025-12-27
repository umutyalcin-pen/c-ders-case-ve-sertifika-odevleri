using System;

namespace CSharpLearning
{
    class Program
    {
       static void Main(string[] args)
       {
         // bu komut ile çıktıya başlık ekliyoruz daha düzenli ve güzel durması amacıylaa
         Console.WriteLine("***** Ücret Listesi *****"); 
         Console.WriteLine();

         // double ile değişken tanımlıyoruz
          
         double elmaUcreti, armutUcreti, muzUcreti, karpuzUcreti, havucUcreti;

         // fiyatları atıyoruz sisteme
         elmaUcreti = 17.92;
         armutUcreti = 12.75;
         muzUcreti = 21.50;
         karpuzUcreti = 15.25;
         havucUcreti = 10.75;

         // fiyatları sırasıyla ekrana yazdırıyoruz
         Console.WriteLine("Elma: " + elmaUcreti + " TL");
         Console.WriteLine("Armut: " + armutUcreti + " TL");
         Console.WriteLine("Muz: " + muzUcreti + " TL");
         Console.WriteLine("Karpuz: " + karpuzUcreti + " TL");
         Console.WriteLine("Havuç: " + havucUcreti + " TL");       
         Console.WriteLine(); // boş satır bırakmak için soldaki komutu kullanıyoruz

         // miktar olarak ne kadar alındığını belirledik ürünlerden
         double elmaGrami = 1.5;
         double armutGrami = 2.5;
         double muzGrami = 6.9;
         double karpuzGrami = 2.3;
         double havucGrami = 1.8;

         // toplam tutarı hesaplıyoruz

         double elmaToplamUcreti = elmaGrami * elmaUcreti;
         double armutToplamUcreti = armutGrami * armutUcreti;
         double muzToplamUcreti = muzGrami * muzUcreti;
         double karpuzToplamUcreti = karpuzGrami * karpuzUcreti;
         double havucToplamUcreti = havucGrami * havucUcreti;

         // output olarak alıyoruz
         Console.WriteLine("***** Ödenecek Tutarlar *****");
         Console.WriteLine("Elma Toplam: " + elmaToplamUcreti + " TL");
         Console.WriteLine("Armut Toplam: " + armutToplamUcreti + " TL");
         Console.WriteLine("Muz Toplam: " + muzToplamUcreti + " TL");
         Console.WriteLine("Karpuz Toplam: " + karpuzToplamUcreti + " TL");
         Console.WriteLine("Havuç Toplam: " + havucToplamUcreti + " TL");

         // toplam tutarı tanımladık
         double alisverisToplamUcreti = elmaToplamUcreti + armutToplamUcreti + muzToplamUcreti + karpuzToplamUcreti + havucToplamUcreti;
         
         Console.WriteLine();
         Console.WriteLine("Alışveriş Toplam Ücreti: " + alisverisToplamUcreti + " TL");
       }
    }
}
