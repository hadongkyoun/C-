using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 111 + 222;
            Console.WriteLine($"a : {a}");
            
            int b = a - 100;
            Console.WriteLine($"b : {b}");

            int c = b * 10;
            Console.WriteLine($"c : {c}");

            // 피연산자 중 한쪽이 부동 소수형이면 부동 소수형으로 형식 변환
            double d = c / 6.3;
            Console.WriteLine($"d : {d}");

            // 괄호가 연산에 포함 안되니까 착오 X ( 문자열 보간식 )
            Console.WriteLine($"22 / 7 = {22/7}({22%7})");

        }
    }
}
