namespace _20241205_task2
{
    //Создайте класс «Товар», со следующими свойствами: id, название, количество и цена.
    //Создайте массив класса и добавьте 5 товаров. Используя лямбда выражение найдите самый дорогой товар.
    internal class Program
    {
        static void Main(string[] args)
        {
            Item i1 = new Item("table", 10, 100.0m);
            Item i2 = new Item("chair", 20, 70.0m);
            Item i3 = new Item("bed", 5, 200.0m);
            Item i4 = new Item("sofa", 7, 150.0m);
            Item i5 = new Item("cabinet", 3, 170.0m);

            Item[] items = { i1, i2, i3, i4, i5 };

            Del d1 = items =>
            {
                decimal maxPrice = items[0].Price;
                int ordernumber = 0;

                for (int i = 1; i < items.Length; i++)
                {
                    if (items[i].Price > maxPrice)
                    {
                        maxPrice = items[i].Price;
                        ordernumber = i;
                    }
                }

                return items[ordernumber];
            };

            Console.WriteLine(d1.Invoke(items).Name);



            Console.ReadKey();
        }

        public delegate Item Del(Item[] items);

        //private static Item FindMax(Item[] items)
        //{
        //    for (int i = 0; i < items.Length; i++)
        //    {
        //        if (func)
        //    }
        //}

        //delegate bool IsEqual(int x);
        //static void Main(string[] args)
        //{
        //    int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    // найдем сумму чисел больше 5
        //    int result1 = Sum(integers, x => x > 5);
        //    Console.WriteLine(result1); // 30
        //    // найдем сумму четных чисел
        //    int result2 = Sum(integers, x => x % 2 == 0);
        //    Console.WriteLine(result2);  //20
        //    Console.Read();
        //}
        //private static int Sum(int[] numbers, IsEqual func)
        //{
        //    int result = 0;
        //    foreach (int i in numbers)
        //    {
        //        if (func(i))
        //            result += i;
        //    }
        //    return result;
        //}
    }

    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Item(string name, int quantity, decimal price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
