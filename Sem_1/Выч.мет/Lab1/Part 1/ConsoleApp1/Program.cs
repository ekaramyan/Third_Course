using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("числа с запятой");
            double x = 1;
            double res = 1;
            while(x!=0)
            {
                res = x;
                x = x / 2;
            }
            Console.WriteLine(res);
            Console.WriteLine("Нажмите на любую клавишу, чтобы продолжить");
            Console.ReadKey();
            Console.WriteLine("целые числа");
            float y = 1;
            float res1 = 1;
            while (y != 0)
            {
                res1 = y;
                y = y / 2;
            }
            Console.WriteLine(res1);

            Console.WriteLine("Теперь машинная бесконечность");
            Console.ReadKey();
            float z = 1;
            float inf = float.PositiveInfinity;
            float res2 = 1;
            int count = 0;
            while (z != inf)
            {
                count++;
                z*=2;
                if (z != inf)
                {
                    res2 = z;
                }
            }
            Console.WriteLine(res2);
            Console.WriteLine("количество итераций " + count);
            Console.ReadKey();
            Console.WriteLine("Машинная бесконечность с double");
            double a = 1.0;
            double inf2 = double.PositiveInfinity;
            double res3 = 1.0;
            int count1 = 0;
            while (a != inf2)
            {
                count1++;
                a *= 2.0;
                if (a != inf2)
                {
                    res3 = a;
                }
            }
            Console.WriteLine(res3);
            Console.WriteLine("количество итераций "+count1);
        }

        
    }
}
