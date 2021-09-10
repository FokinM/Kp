using System;

namespace Lab_1._4
{




    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=1;
            if (args.Length > 0)
            {
                foreach (string str in args)
                {
                    a += Convert.ToInt32(str);
                    b *= Convert.ToInt32(str);
                }
            }

            

            Console.WriteLine("Сумма = " + a);
            Console.WriteLine("Произведение = " + b);
            Console.ReadLine();

        }
    }
}
