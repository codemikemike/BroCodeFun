using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace BroCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you a computer nerd!?");
            // Text color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your face is cyan color from the screen!");
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
            Console.Title = "CodeMike Console App";

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
            Console.WriteLine("Releasing your infos!");

            /*
             *This is a simple console application that demonstrates various features of the C# console.
             * And it is a great way to learn about console applications in C#.
             */

            int x; // declaration
            x = 5; // initialization

            int y = 10; // declaration and initialization

            int z = x + y; // addition

            int age = 21; // variable declaration (whole integer)
            double height = 5.9; // variable declaration (decimal number)
            bool alive = true; // variable declaration (boolean)
            char symbol = 'M'; // variable declaration (character) (Could also be feks. @)
            string name = "Code Mike"; // variable declaration (string)

            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);

            //Constants = immutable values that cannot be changed adds security and performance to programs
            const double PI = 3.14159; // constant declaration
            /*PI = 420; This line will cause a compile-time error because PI is a constant and cannot be changed*/

            // Type Casting = converting one data type to another
            // useful when we accept user input as a string and need to convert it to an integer or double
            //different data types can do different things, so we need to convert them to the right type

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 5;
            double d = Convert.ToDouble(c);

            int e = 10;
            String f = Convert.ToString(e);

            String g = "$";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());
            Console.WriteLine(j.GetType());


            // Wait for user input before closing
            Console.ReadKey();
        }
    }
}

