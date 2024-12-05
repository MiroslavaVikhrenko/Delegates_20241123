namespace _20241205_lambda_task4
{
    //Используя лямбда выражение возвести переданное число во вторую степень.
    internal class Program
    {
        static void Main(string[] args)
        {
            Del d1 = (int x) => Convert.ToInt32(Math.Pow(x, 2));
            Console.WriteLine(d1.Invoke(3));
            Console.ReadKey();
        }

        delegate int Del(int x);
    }
}
