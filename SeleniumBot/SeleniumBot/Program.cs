namespace SeleniumBot {
    public class Program {
        static void Main(string[] args) {
            var web = new AutomationWeb();
            var text = web.TestWeb();

            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}