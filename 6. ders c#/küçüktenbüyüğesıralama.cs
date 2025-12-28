using System; 

namespace CSharpLearning 
{
    class Program 
    {
       static void Main(string[] args) 
       {
        int[] numbers = {45, 82, 52, 41};
        Array.Sort(numbers);
        for(int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);

        }
        Console.Read();
       }
    }
}
