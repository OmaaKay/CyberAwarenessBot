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
        Console.WriteLine("   CYBERSECURITY AWARENESS BOT     ");
        Console.WriteLine("===================================");
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
















/*
string audioPath = "audio/greeting.wav";

if (File.Exists(audioPath))
{
    SoundPlayer player = new SoundPlayer(audioPath);
    player.PlaySync(); //waits until the audio stops to continue
}
else
{
    Console.WriteLine("Audio file not found.");
}
*/