namespace _20241205_task1
{
    //Напишите анонимный метод, который принимает в качестве параметра массив и проверяет, являются ли его элементы упорядоченными по возрастанию.
    internal class Program
    {
        static void Main(string[] args)
        {
            Del d1 = delegate (int[] array) 
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            return false;
                        }
                    }
                }
                return true;
            };

            int[] a1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] a2 = { 0, 7, -2, 9, 11, -50, 0, 1236, 2 };

            Console.WriteLine(d1.Invoke(a1));
            Console.WriteLine(d1.Invoke(a2));

            Console.ReadKey();
        }

        public delegate bool Del(int[] array);
    }
}
