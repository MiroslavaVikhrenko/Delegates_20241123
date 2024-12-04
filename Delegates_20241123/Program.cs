namespace Delegates_20241123
{
    //Создать метод выводящий на экран приветствие. Создать делегат. Добавить метод в делегат. Вызвать делегат.
    internal class Program
    {
        static void Main(string[] args)
        {
            Del del = Hello;

            del.Invoke();

            Console.ReadLine();
        }

        public delegate void Del();
        public static void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
}
