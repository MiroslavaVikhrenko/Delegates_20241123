namespace _20241204_SendMessageDelegatesTask2
{
    internal class Program
    {
        //Создайте класс «SendMessage». Опишите на уровне класса делегат,
        //переменную делегата и метод для отправки сообщения SendMessage с 2-мя параметрами: Заголовок и текст сообщения. 
        //Используя переменную делегата, дать возможность пользователю прописать свою логику отправки сообщения в методе SendMessage.
        static void Main(string[] args)
        {
            Message message = new Message();

            message.del1("fancy title", "blah blah blah");

            Console.ReadKey();
        }
    }

    public class Message
    {
        public string Title { get; set; }
        public string Text { get; set; }

        public delegate void Del(string title, string text);

        public Del del1 = SendMessage;

        public static void SendMessage(string title, string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Title:\n{title}");
            Console.ResetColor();
            Console.WriteLine($"Text:\n{text}");
        }
    }
}
