namespace FlashGerman.Models
{
    public class Test
    {
        public int x;
        public int y;
    }
    class Program
    {
        static void Main()
        {
            var p = new Test();
            p.x = 10; p.y = 20;
            Console.WriteLine($"x = {p.x}");

        }
    }
}
