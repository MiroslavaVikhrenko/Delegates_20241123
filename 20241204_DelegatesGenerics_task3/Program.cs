namespace _20241204_DelegatesGenerics_task3
{
    internal class Program
    {
        //Создайте обобщенный делегат с универсальным параметром, такого вида:   
        //delegate T SomeOp<T>(T v);
        //Создайте 2 метода, с возвращаемым значением int, string и соответственно с одним аргументом int, string.
        //В методе int – просуммируйте все цифры вашего числа, в методе string – переверните строку.Методы вызывать через делегат.
        static void Main(string[] args)
        {
            SomeOp<int> intDel = Sum;
            SomeOp<string> stringDel = InvertString;

            intDel(12345);
            intDel(3333);
            stringDel("Calgary");
            stringDel("Canada");

            Console.ReadKey();
        }

        public delegate T SomeOp<T>(T v);

        public static int Sum (int number)
        {
            int sum = 0;
            int temp = number;

            while (temp > 0)
            {
                sum += temp % 10;
                temp = temp / 10;
            }
            Console.Write($"\nNumber {number}. Sum of digits is : {sum} ");
            return sum;
        }

        public static string InvertString(string str)
        {
            string reverseString = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseString += str[i];
            }
            Console.Write($"\nOriginal string is {str}. Reverse string is : {reverseString} ");
            return reverseString;
        }
    }
}
