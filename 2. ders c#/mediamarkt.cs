using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args) 
       {
        
         // Aynı satırda birden fazla değişken virgülle ayrılarak tanımlanabilir
         int shoesPrice, computerPrice, chairPrice, tvPrice;
         
         // Ürünlerin birim fiyatlarını atıyoruz
         shoesPrice = 100;     
         computerPrice = 200;  
         chairPrice = 50;      
         tvPrice = 150;        

         
         // Kullanıcının gireceği adetleri tutan değişkenler
         int shoesCount, computerCount, chairCount, tvCount;
              
        
         // Convert.ToInt32 → String'i (metin) int'e (tam sayı) çevirir
         Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
         shoesCount = Convert.ToInt32(Console.ReadLine());

         Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
         computerCount = Convert.ToInt32(Console.ReadLine());

         Console.Write("Lütfen aldığınız koltuk sayısını giriniz: ");
         chairCount = Convert.ToInt32(Console.ReadLine());

         Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
         tvCount = Convert.ToInt32(Console.ReadLine());

       
         // Her ürün için: birim fiyat × adet hesaplanır
         // Sonra hepsi toplanarak genel toplam bulunur
         // Matematiksel işlem sırası: önce çarpma (*), sonra toplama (+)
         int total = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;
         
         
         // Metin ve değişken + operatörüyle birleştirilir
         Console.WriteLine("Toplam tutar: " + total + " TL");
       }
    }
}
