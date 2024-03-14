

namespace Swap
{
    class Square
    {
        static void Main(string[] args)
        {
            Console.Write("수를 입력하세요.: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("결과 : {0}", SquareArea(a));
            

        }

         static double SquareArea(double arg)
        {
            return arg*arg;
        }
    }
}
