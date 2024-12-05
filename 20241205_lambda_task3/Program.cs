namespace _20241205_lambda_task3
{
    //Используя анонимный метод, принимать любое количество значений и возвращать наименьшее из всех значений.
    internal class Program
    {
        static void Main(string[] args)
        {
            Del d1 = delegate (int[] ints)
            {
                int min = ints[0];
                for (int i = 0; i < ints.Length; i++)
                {
                    if (ints[i] < min)
                    {
                        min = ints[i];
                    }
                }
                return min;
            };

            int[] ints = { 10, 99, 0, 50, -7, 80, -15, 1, 100 };

            Console.WriteLine(d1.Invoke(ints));

            Console.ReadKey();
        }

        delegate int Del(int[] ints);
    }
}
