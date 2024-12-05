namespace _20241205_task3
{
    internal class Program
    {
        //Предположим, у вас есть список чисел, и вы хотите отфильтровать все четные числа.
        //Вы можете использовать лямбда-выражение для создания метода, который проверяет,
        //является ли число четным или нет, а затем использовать метод Filter() для
        //применения этой функции к каждому элементу списка и возвращения нового списка, содержащего только нечетные числа. 

        //Решите задачу с использованием:

        //Отдельный метод.
        //Анонимный метод.
        //Лямбда-выражение.
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int[] nums2 = FilterEven(nums);

            for (int i = 0; i < nums2.Length; i++)
            {
                Console.Write($" {nums2[i]}");
            }
            Console.ReadKey();
        }

        public delegate bool IsEven(int x);

        public static int[] FilterEven(int[] nums)
        {
            IsEven d = x => x % 2 == 1;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (d.Invoke(nums[i]))
                {
                    count++;
                }
            }

            int[] nums2 = new int[count];

            int count2 = 0;

            for (int i = 0;i < nums.Length;i++)
            {
                if (d.Invoke(nums[i]))
                {
                    nums2[count2] = nums[i];
                    count2++;
                }
            }

            return nums2;
        }
    }
}
