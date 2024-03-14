using System;

namespace MyConsoleApp
{
    class NullCoalescing
    {
        static void Main(string[] args)
        {
            //null 병합 연산자 => ??

            int? num = null;
            Console.WriteLine($"{num ?? 0}");

            num = 99;
            Console.WriteLine($"{num ?? 0}");

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}");
        }
    }
}
