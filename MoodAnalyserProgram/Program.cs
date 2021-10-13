using System;
using System.Reflection;

namespace MoodAnalyserProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Mood Analyser Program");
            //creating object for the MoodAnalayser class
            Console.Write("Enter Your current mood : ");
            string inputdata = Console.ReadLine();
            MoodAnalyser analyser = new MoodAnalyser(inputdata);
            string input = analyser.moodAnalyser();
            Console.WriteLine(input);

            Reflections reflections = new Reflections();
            reflections.ReflectionTests();
        }
    }
}
