namespace _20241205_task4
{
    public class Program
    {
        //Опишите делегат с требуемой сигнатурой. Используя блочное лямбда-выражение реализуйте основной алгоритм задачи.
        //Осуществите использование делегата в программе с применением введенных пользователем исходных данных.
        //Напишите код, который принимает для каждого из 1234 учеников района дату его рождения(день, месяц, год).
        //Программа должна подсчитать и вывести на экран число детей, родившихся зимой, весной, летом и осенью.

        public delegate bool IsEqual(int x);
        static void Main(string[] args)
        {
            Child[] children =
            {
            new Child("Erik", new DateTime(2013, 10, 1)),
            new Child("Adam", new DateTime(2012, 11, 1)),
            new Child("Chris", new DateTime(2012, 1, 1)),
            new Child("Alex", new DateTime(2010, 3, 1)),
            new Child("Kate", new DateTime(2014, 12, 1)),
            new Child("Bridget", new DateTime(2015, 8, 1)),
            new Child("Erica", new DateTime(2020, 6, 1)),
            new Child("Irene", new DateTime(2023, 7, 1)),
            new Child("Tom", new DateTime(2021, 9, 1)),
            new Child("Carl", new DateTime(2020, 8, 1)),
            new Child("Hiro", new DateTime(2018, 2, 1)),
            new Child("Yuko", new DateTime(2017, 4, 1)),
            new Child("Haolin", new DateTime(2017, 5, 1)),
            new Child("Sandy", new DateTime(2015, 10, 1)),
            new Child("Steve", new DateTime(2016, 1, 1)),
            new Child("Jerry", new DateTime(2022, 5, 1)),
            new Child("Julia", new DateTime(2023, 6, 1)),
            new Child("Jane", new DateTime(2024, 9, 1)),
            new Child("Eugene", new DateTime(2021, 12, 1)),
            new Child("Miko", new DateTime(2019, 8, 1))
            };



            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---------------Born in Winter---------------");
            Console.ResetColor();
            FilterBySeason(children, x => x == 12 || x == 1 || x == 2);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------Born in Spring---------------");
            Console.ResetColor();
            FilterBySeason(children, x => x == 3 || x == 4 || x == 5);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---------------Born in Summer---------------");
            Console.ResetColor();
            FilterBySeason(children, x => x == 6 || x == 7 || x == 8);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------Born in Fall---------------");
            Console.ResetColor();
            FilterBySeason(children, x => x == 9 || x == 10 || x == 11);
            Console.WriteLine();

            Console.ReadKey();
        }
        private static void FilterBySeason(Child[] children, IsEqual isEqual)
        {
            int result = 0;
            foreach (Child child in children)
            {
                if (isEqual(Convert.ToInt32(child.DoB.Month)))
                {
                    result++;
                    Console.WriteLine($"{child.ToString()}");
                }
            }
            Console.WriteLine($"--------------\nTotal: {result} kids\n");

        }

    }

    public class Child
    {
        public string Name { get; set; }
        public DateTime DoB { get; set; }

        public Child(string name, DateTime dt)
        {
            Name = name;
            DoB = dt;
        }

        public override string ToString()
        {
            return $"{Name}: DoB: {DoB.ToString()}";
        }
    }
}
