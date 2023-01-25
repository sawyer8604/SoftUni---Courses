namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Cake cake = new Cake("Cake");

            System.Console.WriteLine($"{cake.Name}, {cake.Price}, {cake.Grams}");
        }
    }
}