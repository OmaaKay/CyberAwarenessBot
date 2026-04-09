// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Media; 
using System.Threading.Tasks; 


namespace CyberAwarenessBot
{
class Program
{
    static void Main(string[] args)
    {
       
        // Part 1: Path to WAV
        string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "audio", "greeting.wav");
Console.WriteLine("Looking for audio at: " + audioPath);
      // string audioPath = "audio/greeting.wav";
      
        if (File.Exists(audioPath))
        {
            SoundPlayer player = new SoundPlayer(audioPath);
            player.PlaySync();//do not continue to code unlessaudio file has finished playing
        }
        else
        {
            Console.WriteLine("Audio file not found.");
        }

        // Part 2: ASCII art
        Console.WriteLine("===================================");
        Chatbot.DrawBotLogo();
        Console.WriteLine("===================================");






  Chatbot.DrawHeader("South African Cyber-Safety Assistant");

            // Part 3: User Interaction
            Chatbot.Type("[BOT]: Dumelang! I am your security assistant.", ConsoleColor.Cyan);
            Chatbot.Type("[BOT]: To begin, may I ask what your name is?", ConsoleColor.Cyan);

            Console.Write("\n[YOU]: ");
            string nameInput = Console.ReadLine();

            // 3. Input Validation (Requirement #5 - 5 Marks)
            while (string.IsNullOrWhiteSpace(nameInput))
            {
                Chatbot.Type("(!) Please enter a valid name so I can personalize your session.", ConsoleColor.Red);
                Console.Write("[YOU]: ");
                nameInput = Console.ReadLine();
            }

            User user = new User(nameInput);

            // 4. Personalized Greeting (Requirement #4)
            Console.Clear();
            Chatbot.DrawHeader("Session Active");
            Chatbot.Type($"Hello, {user.Name}. It is vital for South Africans to stay safe online.", ConsoleColor.Green);
            Chatbot.DrawDivider();
            
            Chatbot.Type("I can help you with: \n1. Password Safety \n2. Phishing Scams \n3. Safe Browsing");
            Chatbot.Type("\nWhat would you like to ask about first?", ConsoleColor.Yellow);

            















/*


    //make the bot "talk" by printing messages with a delay AND DRAW IT
        

    // --- Part 3: User Interaction ---

// Set a cool color for the bot's voice
Console.ForegroundColor = ConsoleColor.Cyan;
TypeLine("\n[BOT]: Hello! I am your South African Cyber-Security Assistant.");
TypeLine("[BOT]: Before we begin our safety briefing, what is your name?");
Console.ResetColor();

Console.Write("\n[YOU]: ");
string inputName = Console.ReadLine();

// Input Validation (Requirement #5)
while (string.IsNullOrWhiteSpace(inputName))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("(!) I didn't catch that. Please enter your name to continue.");
    Console.ResetColor();
    Console.Write("[YOU]: ");
    inputName = Console.ReadLine();
}

// Create the User object
User currentUser = new User(inputName);

// Personalized Response (Requirement #3 & #4)
Console.Clear(); // Keeps it professional
// Re-display your ASCII Bot here so it stays at the top!

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("==================================================");
TypeLine($"Welcome, {currentUser.Name}! It's a pleasure to meet you.");
TypeLine("I am programmed to help you navigate the digital landscape of SA safely.");
Console.WriteLine("==================================================");
Console.ResetColor();

*/









    }

    static void TypeLine(string text)
{
    foreach (char c in text)
    {
        Console.Write(c);
        Thread.Sleep(30); // Adjust speed here (30ms is a natural pace)
    }
    Console.WriteLine();
}

}

}//Namespace















