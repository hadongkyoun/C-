using System.Collections;
using static System.Console;

namespace MyConsoleApp
{
    class NullConditionalOperator
    {
        static void Main(string[] args)
        {
            // a가 null인 경우 ( 보통 우리는 a가 null인지 아닌지 모른다 가정한거임 )
            // null 조건부 연산자 => ?.
            ArrayList a = null;
            a?.Add("축구");
            a?.Add("야구");
            // a가 null 일 수도 있으니 a의 원소에 접근할때도 ?를 붙여줘야 한다.
            WriteLine($"a[0] : {a?[0]}\na[1] : {a?[1]}");

            a = new ArrayList();
            a?.Add("축구");
            a?.Add("야구");
            WriteLine($"a[0] : {a?[0]}\na[1] : {a?[1]}");
        }
    }
}
