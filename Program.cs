namespace BroCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I like pizzadd!");
            // Text color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("This is cyan!");
            Console.ResetColor();
            // Loop through all colors:
            /*foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"This is {color}");
            }
            Console.ResetColor();*/
            // Fake Loading/Progress Bar
            for (int i = 0; i <= 100; i += 10)
            {
                Console.Write($"\rLoading: {i}%");
                System.Threading.Thread.Sleep(200);
            }
            Console.WriteLine("\nDone!");
            // ASCII Art or Animations
            string[] spinner = { "|", "/", "-", "\\" };
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"\r{spinner[i % spinner.Length]} Working...");
                System.Threading.Thread.Sleep(100);
            }
            // Position Text Anywhere
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Hello from (10,5)!");
            // Console Title
            Console.Title = "BroCode Console App";

            // Matrix Effect (Mini Version) - commented out properly
            /*
            Random rand = new Random();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write((char)rand.Next(33, 126));
                System.Threading.Thread.Sleep(10);
            }
            */

            // Clear Screen Dramatically and Play Sound
            Console.Clear();
            Console.Beep(800, 1000);
            Console.WriteLine("Everything's gone!");

            /*
             *This is a simple console application that demonstrates various features of the C# console.
             * And it is a great way to learn about console applications in C#.
             */

            // Wait for user input before closing
            Console.ReadKey();
        }
    }
}

