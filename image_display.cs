using System;
using System.IO;

namespace logo_display
{
    internal class Program
    {
        static void Main(string[] args)
        {
            image_display display = new image_display();
            display.ShowAsciiArt();
        }
    }

    internal class image_display
    {
        public string FullPath { get; private set; }

        public image_display()
        {
            // Get the application directory
            string full_location = AppDomain.CurrentDomain.BaseDirectory;

            // Remove "bin\Debug\" or "bin\Release\" from the path
            string new_path = full_location.Replace("bin\\Debug\\", "").Replace("bin\\Release\\", "");

            // Combine the paths to locate the ASCII text file
            FullPath = Path.Combine(new_path, "ascii_image.txt");
        }

        public void ShowAsciiArt()
        {
            try
            {
                if (File.Exists(FullPath))
                {
                    string asciiArt = File.ReadAllText(FullPath);
                    Console.WriteLine(asciiArt);
                }
                else
                {
                    Console.WriteLine("ASCII art file not found: " + FullPath);
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }

            // Set text color to Cyan for the welcome message
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Display the welcome message
            Console.WriteLine("\nWelcome to Cyber Guardian!");

            // Reset text color to default
            Console.ResetColor();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();  // Wait for key press
        }
    }
}
