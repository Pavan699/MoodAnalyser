using System;

namespace MoodAnalyserProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Mood Analyser Program");
            MoodAnalyser moodAna1 = new MoodAnalyser();//calling default constructor
            MoodAnalyser moodAna2 = new MoodAnalyser("I am in Happy Mood");//parameterised constructor
        }
    }
}
