using System;

namespace MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Program");
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            Console.WriteLine(moodAnalyser.AnalyseMood());
        }
    }
}
