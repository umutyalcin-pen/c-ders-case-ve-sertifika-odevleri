using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args) 
       {
        
        // char → tek karakter tipinde değişken (işlem sembolü için)
        int number1, number2, result;
        char symbol;

        // Convert.ToInt32 → String'i tam sayıya çevirir
        Console.Write("1. sayıyı giriniz: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2. sayıyı giriniz: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        // Convert.ToChar → String'i tek karaktere çevirir
        // Kullanıcı +, -, *, / sembollerinden birini girer
        Console.Write("İşlemi giriniz: ");
        symbol = Convert.ToChar(Console.ReadLine());


        // switch: symbol değişkeninin değerine göre farklı işlemler yapar
        // char değerler tek tırnak içinde yazılır: '+', '-', '*', '/'
        switch (symbol)
        {
            // case '+': Kullanıcı + girdiyse toplama işlemi yapılır
            case '+':
                result = number1 + number2;
                break; // switch bloğundan çık

            // case '-': Kullanıcı - girdiyse çıkarma işlemi yapılır
            case '-':
                result = number1 - number2;
                break;

            // case '*': Kullanıcı * girdiyse çarpma işlemi yapılır
            case '*':
                result = number1 * number2;
                break;

            // case '/': Kullanıcı / girdiyse bölme işlemi yapılır
            case '/':
                result = number1 / number2;
                break;

            // default: Hiçbir case eşleşmezse (geçersiz sembol girilirse)
            // return: Main metodunu ve programı sonlandırır
            default:
                Console.WriteLine("Geçersiz işlem!");
                return;
        }

        //ekranay yazdırıyoruz
        Console.WriteLine("Sonuç: " + result);
       }
    }
}
