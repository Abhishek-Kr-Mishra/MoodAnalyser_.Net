using System;

namespace MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Program");
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Sad Mood");
            Console.WriteLine(moodAnalyser.AnalyseMood());
        }
    }
}
