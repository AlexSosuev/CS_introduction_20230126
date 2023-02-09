// 51. С клавиатуры вводится число N. Затем вводится N чисел.
namespace GeekBrains
{
    namespace Introduction
    {
        class Task051
        {
            static void Main()
            {
                int N = Convert.ToInt32(Console.ReadLine());
                int k = 0;
                for (int i = 0; i < N; i++)
                {
                    int n = int.Parse(Console.ReadLine());
                    if (N > 0) k++;
                }
                System.Console.WriteLine(k);
            }
        }
    }
}
