using System;

namespace maximum
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Введите 3 любых числа, и я скажу какое больше :)");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b ||c < b)
            {
                Console.WriteLine(b);
            if (a < c||b < c )
                {
                    Console.WriteLine(c);
            if (c < a || b < a)
                    {
                        Console.WriteLine(a)
                    }
                }
            }
            
        }
    }
}
