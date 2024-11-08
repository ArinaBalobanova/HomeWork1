using System;

namespace GreetingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("ПРивет" + name + "+");
            Console.ReadKey();
        }

    }
}