using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args) 
       {
        
        // Kullanıcıya kaç kez yazdırılacağını soruyoruz
        Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
        
        // Console.ReadLine → Kullanıcının girdiğini okur (string döner)
        // int.Parse → String'i tam sayıya çevirir
        int finishValue = int.Parse(Console.ReadLine());

       
        for(int i = 1; i <= finishValue; i++)
        {
            // Her turda ekrana mesaj yazdırılır
            Console.WriteLine("İ");

            // Console.Read → Her yazdırmadan sonra bir tuşa basılmasını bekler
            // NOT: Bu satır döngü içinde olduğu için her mesajdan sonra bekler
            // Eğer tüm mesajlar peş peşe yazdırılsın istiyorsanız bu satırı silin
            Console.Read();
        }
       }
    }
}
