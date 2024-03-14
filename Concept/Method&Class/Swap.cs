namespace Swap
{

    class Program
    {

        static void Main(string[] args)
        {
            int x = 4;
            int y = 5;
            
            Console.WriteLine($"x : {x}, y : {y}");

            Swap(ref x, ref y);

            Console.WriteLine($"x : {x}, y : {y}");
        }

        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
