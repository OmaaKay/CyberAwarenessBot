using System;
using System.Threading;
//class mainly for holding the ASCII art and other UI elements, to keep Program.cs cleaner and more focused on the flow of the conversation

namespace CyberAwarenessBot
{
    public class Chatbot
    {

        
        //  Image Display
        public static void DrawBotLogo()
        {
            Console.Clear(); 
            Console.ForegroundColor = ConsoleColor.Green; 

            // This is the actual ASCII artwork (raw string literal)
            string botLogo = @"
         |----------------------------------------- |
         |    |o  o|   CYBER GUARD SA   |
         |    |_^_|     SOUTH AFRICA       |
         |   /|___|\     CYBER UNIT           |
         |   ( |   | )                                      |
         |    | __ |         [ALERT]                |
         |     / \ \                                        |
         |                                                  |
         |------------------------------------------|

";
            Console.WriteLine(botLogo);
            Console.ResetColor();
        }

        // Enhanced UI - Typing Effect
        public static void Type(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(25); // The "Typewriter" speed
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        // Decorative Borders
        public static void DrawDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("--------------------------------------------------");
            Console.ResetColor();
        }

        public static void DrawHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==================================================");
            Console.WriteLine($"      {title.ToUpper()}      ");
            Console.WriteLine("==================================================");
            Console.ResetColor();
        }


// Method to create a typing effect for a conversational feel(responses specific)
public void TypeMessage(string message, ConsoleColor color = ConsoleColor.White) 
{
    Console.ForegroundColor = color;
    foreach (char c in message)
    {
        Console.Write(c);
        // Slight delay for "conversational feel"
        System.Threading.Thread.Sleep(25); 
    }
    Console.WriteLine();
    Console.ResetColor();
}



    }
}
