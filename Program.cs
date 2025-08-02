using System;
using System.Runtime.InteropServices;

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

            // Fake Loading/Progress Bar
            for (int i = 0; i <= 100; i += 10)
            {
                Console.Write($"\rLoading: {i}%");
                System.Threading.Thread.Sleep(200);
            }
            Console.WriteLine("\nDone!");

            // ASCII Art or Animations
            string[] spinner = { "|", "/", "-", "\\" };
            for (int k = 0; k < 20; k++)
            {
                Console.Write($"\r{spinner[k % spinner.Length]} Working...");
                System.Threading.Thread.Sleep(100);
            }

            // Position Text Anywhere
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Hello from (10,5)!");

            // Console Title
            Console.Title = "CodeMike Console App";

            // Clear Screen Dramatically and Play Sound (Windows only)
            Console.Clear();
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.Beep(800, 1000);
            }
            else
            {
                Console.WriteLine("Beep not supported on this platform.");
            }

            Console.WriteLine("Releasing your infos!");

            // Variable demos
            int x = 5;
            int y = 10;
            int z = x + y;


            double height = 5.9;
            bool alive = true;
            char symbol = 'M';

            Console.WriteLine("What's your name?");
            string? name = Console.ReadLine(); // Nullable string to handle empty input

            if (string.IsNullOrWhiteSpace(name)) // Check if the input is null or whitespace
            {
                name = "Anonymous"; // Default value if no name is provided
            }

            Console.WriteLine("Hello " + name);


            // Ask the user to enter their age
            Console.WriteLine("What's your age?");

            // Read the user's input from the console (can be null)
            string? input = Console.ReadLine();

            // Declare a nullable integer to store the age
            int? age = null;

            // Check if the input is not null or whitespace AND try to parse it into an integer
            if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int parsedAge))
            {
                // If parsing succeeds, store the value in the nullable age variable
                age = parsedAge;

                // Output the parsed age
                Console.WriteLine($"Your age is: {age}");
            }
            else
            {
                // If input was empty or invalid (e.g. not a number), print an error message
                Console.WriteLine("Invalid input. Age not set.");
            }


            Console.WriteLine("Hello " + name);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);
            Console.WriteLine("Your age is: " + age);

            // Constants
            const double PI = 3.14159;
            Console.WriteLine("Value of PI is: " + PI);

            // Type casting
            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 5;
            double d = Convert.ToDouble(c);

            int e = 10;
            string f = Convert.ToString(e);

            string g = "$";
            char h = Convert.ToChar(g);

            string strBool = "true"; // <-- changed from 'i'
            bool j = Convert.ToBoolean(strBool);

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
