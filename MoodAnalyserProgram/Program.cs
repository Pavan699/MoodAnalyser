using System;

namespace MoodAnalyserProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Mood Analyser Program");                   
            MoodAnalyser moodAna = new MoodAnalyser();
            Console.Write("Enter Your current mood : ");
            string inputdata = Console.ReadLine();
            Console.WriteLine(moodAna.moodAnalyser(inputdata));
        }
    }
}
