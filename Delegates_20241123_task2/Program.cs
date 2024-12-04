using System.Globalization;

namespace Delegates_20241123_task2
{
//    Создайте и заполните массив на 30 элементов.
//Создайте 4 метода, которые принимают массив и выполняют: 

//1) Сортировка и вывод массива в по возрастанию.
//2) Сортировка и вывод массива в по убыванию.
//3) Создание и вывод массива только с четными значениями.
//4) Создание и вывод массива только с нечетными значениями.

//Создайте делегат, объекты делегата на каждый метод, после объедините все объекты делегата в один и отобразите операции на экран.
//Консольный вывод может выглядеть следующим образом:

//Исходный массив:
//2       -4      10      5       -6      9
//Отсортированный массив в большую сторону:
//-6      -4      2       5       9       10
//Четный массив:
//-6      -4      2       6       10      10
//Отсортированный массив в меньшую сторону:
//10      10      6       2       -4      -6
//Нечетный массив:
//11      11      7       3       -3      -5
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = PopulateArray(30);
            Del del1 = AscSort;
            Del del2 = DescSort;
            Del del3 = EvenSort;
            Del del4 = UnevSort;

            Del del5 = del1 + del2 + del3 + del4;

            del5(nums);

            Console.ReadKey();
        }

        public delegate int[] Del(int[] nums);

        public static int[] PopulateArray(int num)
        {
            Random rnd = new Random();
            int[] nums = new int[num];

            for (int i = 0; i < num; i++)
            {
                nums[i] = rnd.Next(-99, 100);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nFreshly created array:");
            Console.ResetColor();
            PrintArray(nums);
            return nums;
        }
        public static void PrintArray(int[] nums)
        {
            Console.WriteLine();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                {
                    Console.Write($" {nums[i]}");
                }
                else
                {
                    Console.Write($"{nums[i]} |");
                }               
            }
            Console.WriteLine();
        }

        public static int[] AscSort(int[] nums)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAscSort in progress.....");
            Console.ResetColor();
            int temp;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            PrintArray(nums);
            return nums;
        }

        public static int[] DescSort(int[] nums)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nDescSort in progress.....");
            Console.ResetColor();
            int temp;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            PrintArray(nums);
            return nums;
        }

        public static int[] EvenSort(int[] nums)
        {
            int count = 0;

            for (int i = 0;i < nums.Length;i++)
            {
                if (nums[i] % 2 == 0)
                {
                    count++;
                }
            }

            int[] nums2 = new int[count];

            int count2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    nums2[count2] = nums[i];
                    count2++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nEven sort completed:");
            Console.ResetColor();
            PrintArray(nums2);
            return nums2;
        }

        public static int[] UnevSort(int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    count++;
                }
            }

            int[] nums2 = new int[count];

            int count2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    nums2[count2] = nums[i];
                    count2++;
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nUNeven sort completed:");
            Console.ResetColor();
            PrintArray(nums2);
            return nums2;
        }
    }
}
