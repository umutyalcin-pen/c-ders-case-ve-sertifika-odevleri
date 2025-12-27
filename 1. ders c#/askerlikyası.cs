using System;

namespace CSharpLearning
{
    class Program
    {
       static void Main(string[] args)
       {
         // kullanıcıdan ilk bilgiyi almak ve tek tuş ile cevaplamak için ilk komutu girdik

         Console.Write("18 yaşından büyük müsünüz? (evet: e, hayır: h) ");
         //verilen cevabı kullanıcıdan çekmek için bu komutu yazdık
         string yas = Console.ReadLine();

         Console.Write("Okula gidiyor musunuz? (evet: e, hayır: h) ");
         // yaş ile aynı mantık olarak okul ile alakalı bilgiyi de bu iki komut ile çekiyoruz
         string okulaGitmeDurumu = Console.ReadLine();

        //verilen e veya h cevaplarına göre hesaplanan sonucu ekrana yazdırıyoruz
         
        if (yas == "e" && okulaGitmeDurumu == "h") 
        { 
            Console.WriteLine("Askerlik yaşınız geldi!");
        }
       
        else if (yas == "e" && okulaGitmeDurumu == "e")
        {
            Console.WriteLine("Askerliğinizi okuldan sonra yapacaksınız");
        }
               
               // eğer iki kısım da hayır ise alttaki komut döndürülür eğer ikisinden en az biri "e" ise üstteki komutlardan birisi döndürülür
        else
        {
            Console.WriteLine("Askerlik yaşınız daha gelmedi");
        }
       }
    }
}
