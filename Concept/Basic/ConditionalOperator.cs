using System;

namespace MyConsoleApp
{
    class ConditionalOperator
    {
        // 조건식 ? 참일 때의 값 : 거짓일 때의 값

        static void Main(string[] args)
        {
            int a;
            Console.Write("a의 값을 입력 하시오. : ");
            a = Console.Read();
            string result = (a % 2) == 0 ? "a는 짝수" : "a는 홀수";
            Console.Write(result);
        }

    }
}
