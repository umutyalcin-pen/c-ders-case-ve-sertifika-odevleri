using System; // kütüphane aktardık

namespace CSharpLearning // klasör
{
    class Program // sınıf tanımlaması
    {
       static void Main(string[] args) 
       {
        // int ile atama ve tanımlama yapıyoruz

        int hamburgerFiyati = 300; 
        int kolaFiyati = 50;
        int patatesFiyati = 100;
        int peceteFiyati = 50;
           
        //bu kısımda sadece tanımlama yapıyoruz

        int hamburgerCount;
        int kolaCount;
        int patatesCount;
        int peceteCount;

        //ürünlerin hesap sonrası değerlerini tutacak değişkenleri atıyoruz

        int toplamHamburgerFiyati;
        int toplamKolaFiyati;
        int toplamPatatesFiyati;
        int toplamPeceteFiyati;

        //adet değerlerini veri olarak atıyoruz

        hamburgerCount = 3; 
        kolaCount = 2;      
        patatesCount = 1;  
        peceteCount = 4;    
     
        //adet ile birim fiyatını çarpıyoruz

        toplamHamburgerFiyati = hamburgerCount * hamburgerFiyati; 
        toplamKolaFiyati = kolaCount * kolaFiyati;               
        toplamPatatesFiyati = patatesCount * patatesFiyati;     
        toplamPeceteFiyati = peceteCount * peceteFiyati;         

        //son olarak bütün ürünleri birbiriyle topluyoruz

        int totalPrice = toplamHamburgerFiyati + toplamKolaFiyati + toplamPatatesFiyati + toplamPeceteFiyati;

        //bu kısımda ise ekrana yazdırıyoruz
        
        Console.WriteLine("Toplam ödenecek tutar: " + totalPrice + " TL"); 
       }
    }
}