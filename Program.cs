using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Метод простых итераций           " +  "Метод Зейделя");
            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Решение тестовой системы           " + "Решение варианта");

                    switch(int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine("Дана функция:");
                            Console.WriteLine("100*x1 + 2*x2 + 3*x3 = 105");
                            Console.WriteLine("x1 + 100*x2 + 3*x3 = 104");
                            Console.WriteLine("x1 + 2*x2 + 100*x3 = 103");
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine();
                    break;

            }
        }
        int Function1(int x2, int x3)
        
        {
            int x1 = (105 - 2 * x2 - 3 * x3) / 100;
            return x1;
        }
        int Function2(int x1, int x3)
        {
            int x2 = (104 - x1 - 3 * x3) / 100;
            return x2;
        }
        int Function3(int x1, int x2)
        {
            int x3 = (103 - x1 + 2 * x2) / 100;
            return x3;
        }
    }
}
