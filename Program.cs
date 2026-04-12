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

            // 3. Input Validation (requirement 5)
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
            
            Chatbot.Type("I can help you with: \n1. Password Safety \n2. Phishing Scams \n3. Safe Browsing.Type 'exit' to stop.");
            Chatbot.Type("\nWhat would you like to ask about first?", ConsoleColor.Yellow);

        BotBrain botBrain = new BotBrain();

   // The Conversation Loop---I am getting problems in my code from here
        bool keepTalking = true;
        while (keepTalking)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{user.Name.ToUpper()}: ");
            string input = Console.ReadLine();

            if (input != null && input.ToLower() == "exit")
            {
                keepTalking = false;
                continue;
            }

           
Chatbot cb = new Chatbot();
        if (!string.IsNullOrWhiteSpace(input))
{
    string response = botBrain.GetResponse(input);
    //Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"BOT: {response}\n");

    //implementing a typing feel
    cb.TypeMessage(response, ConsoleColor.Green); //ConsoleColor.Green
    Chatbot.DrawDivider();
}
else
{
    Console.WriteLine("BOT: Please enter a valid question.\n");
}
        }

        Chatbot.Type("Thank you for chatting with me. Stay safe online!", ConsoleColor.Green);
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















