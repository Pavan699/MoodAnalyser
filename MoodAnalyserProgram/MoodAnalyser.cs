using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProgram
{
    /// <summary>
    /// MoodAnalyser class to analyse mood
    /// </summary>
    class MoodAnalyser
    {
        //class fields
        public string data = "I am In Sad Mood";
        /// <summary>
        /// MoodAnalyser() default constructor
        /// </summary>
        public MoodAnalyser()
        {
            if (data.ToLower().Contains("sad"))            
                Console.WriteLine("Sad");            
            else            
                Console.WriteLine("Happy");            
        }
        /// <summary>
        /// MoodAnalyser(input) constructor with parameter
        /// </summary>
        public MoodAnalyser(string input)
        {
            this.data = input;
            if(data.ToLower().Contains("sad"))
                Console.WriteLine("Sad");
            else
                Console.WriteLine("Happy");
        }
    }
}
