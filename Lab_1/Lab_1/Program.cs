using System;

namespace Lab_1
{

    class Password
    {
        public string pas = "dfggde2";
    }


    class Program
    {
        static void Main(string[] args)
        {
            Password pas_1 = new Password();

            Console.WriteLine("Введите пароль:");
            while (pas_1.pas != Console.ReadLine())
            {
                Console.WriteLine("не совпал");
            }
            Console.WriteLine("Cовпал");

            Console.ReadLine();
        }
    }
}
