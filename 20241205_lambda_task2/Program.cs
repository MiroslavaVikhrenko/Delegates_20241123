namespace _20241205_lambda_task2
{
    //Принимаете 2 числа, используя анонимные методы выполняйте 4 арифметические операции.
    internal class Program
    {
        static void Main(string[] args)
        {
            Del d1 = delegate (int x, int y)
            {
                return x + y;
            };

            Console.WriteLine(d1.Invoke(10, 5));

            d1 = delegate (int x, int y)
            {
                return x - y;
            };

            Console.WriteLine(d1.Invoke(30, 20));

            d1 = (int x, int y) => x * y;
            Console.WriteLine(d1.Invoke(3, 5));

            d1 = (x, y) => x / y;
            Console.WriteLine(d1.Invoke(20, 10));

            Console.ReadKey();
        }

        delegate int Del(int x, int y);
    }
}
