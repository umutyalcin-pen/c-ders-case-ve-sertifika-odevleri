using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args) 
       {
        
        Console.Write("Lütfen kullanıcı adı giriniz: ");
        
        
        // Okunan değer 'userName' adlı string değişkene kaydedilir
        string userName = Console.ReadLine();
        
        
        // '!=' operatörü "eşit değilse" anlamına gelir
        // Eğer girilen kullanıcı adı "admin" DEĞİLSE bu blok çalışır
        if (userName != "admin")
        {
            Console.WriteLine("Kullanıcı adınız yanlış!");
        }
        // 'else' → if koşulu yanlışsa (yani userName "admin" ise) bu blok çalışır
        else
        {
            Console.WriteLine("Hoş geldiniz Admin");
        }
       }
    }
}
