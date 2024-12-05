using System;

namespace _20241205_delegates_task1
{
    //Реализуйте метод «Where», который в качестве параметра принимает массив и делегат (предикат).
    //С помощью делегата, пользователь может задать условие, по которому он получит из метода элементы.
    //К примеру, все элементы, которые делятся на 2 без остатка или всех пользователей старше 35 лет.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 4, 6, 7, 8, 9, 3, 2, 1};
            MyFunc<int> d1 = Where1;
            d1(nums, Where1);

            int[] nums2 = { 10, 15, 36, 40, 50, 9, 20 };
            d1 = Where2;
            d1(nums2, Where2);
            Console.ReadKey();
        }

        public delegate T[] MyFunc<T>(T[] source, MyFunc<T> del);

        static void PrintArray(int[] array)
        {
            Console.WriteLine("Array");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static int[] Where1(int[] nums, MyFunc<int> ppredicate)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2  == 0)
                {
                    count++;
                }
            }

            int[] nums2 = new int[count];
            int count2 = 0;

            for (int i = 0;i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    nums2[count2] = nums[i];
                    count2++;
                }
            }

            PrintArray(nums2);
            return nums2;
        }

        static int[] Where2(int[] nums, MyFunc<int> ppredicate)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 35)
                {
                    count++;
                }
            }

            int[] nums2 = new int[count];
            int count2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >  35)
                {
                    nums2[count2] = nums[i];
                    count2++;
                }
            }
            PrintArray(nums2);
            return nums2;
        }

        //static T[] Where<T>(T[] source, MyFunc<T> predicate)
        //{

        //}
    }
}
