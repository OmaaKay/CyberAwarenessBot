// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Media; 
using System.Threading.Tasks; 



class Program
{
    static void Main(string[] args)
    {
        // Path to WAV
       string audioPath = "audio/greeting.wav";
      
        if (File.Exists(audioPath))
        {
            SoundPlayer player = new SoundPlayer(audioPath);
            player.PlaySync();//do not continue to code unlessaudio file has finished playing
        }
        else
        {
            Console.WriteLine("Audio file not found.");
        }

        // ASCII art
        Console.WriteLine("===================================");
        Console.WriteLine("   CYBERSECURITY AWARENESS BOT     ");
        Console.WriteLine("===================================");

        // Ask for user name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine()!;
        Console.WriteLine($"Hello {name}, nice to meet you!");

    }
}


















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