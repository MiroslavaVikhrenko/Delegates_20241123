using System.Net.NetworkInformation;

namespace Delegates20241204_task1
{
    internal class Program
    {
        //Напишите "пинг-понг": 2 класса Ping и Pong один уведомляет другого, о том, что "произошёл пинг",
        //другой - о том, что "произошёл понг", одна пара объектов "играют" между собой, другая пара - между собой и т.д.
        //Использовать делегаты.
//        Выводить на консоль соответствующие сообщения, что-то вроде такого:

//Ping received Pong.
//Pong received Ping.
//Ping received Pong.
//Pong received Ping.
        static void Main(string[] args)
        {

            Ping pi = new Ping("Ping 1");
            Pong po = new Pong("Pong 2");

            int score = 0;

            Del del1 = pi.NotifyPi;
            del1 += po.NotifyPo;

            while (score <= 10)
            {
                del1();
                score += 2;
            }

            Console.WriteLine("------------------------------------------------------------------------");

            Ping pi2 = new Ping("Ping 3");
            Pong po2 = new Pong("Pong 4");

            int score1 = 0;

            del1 = pi2.NotifyPi;
            del1 += po2.NotifyPo;

            while (score1 <= 10)
            {
                del1();
                score1 += 2;
            }

            Console.ReadKey();
        }
    }
    public delegate void Del();
    public class Ping
    {
        public string Name { get; set; }

        public Ping(string name)
        {
            Name = name;
        }

        public  void NotifyPi()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Name} received a pong");
            Console.ResetColor();
        }
    }
    public class Pong
    {
        public string Name { get; set; }

        public Pong(string name)
        {
            Name = name;
        }
        public void NotifyPo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Name} received a ping");
            Console.ResetColor();
        }
    }

}
