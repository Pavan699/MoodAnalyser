using System;

namespace MoodAnalyserProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Mood Analyser Program");
            MoodAnalyser moodAna = new MoodAnalyser();
            Console.WriteLine(moodAna.Check("I m in Any mood"));
        }
    }
}
