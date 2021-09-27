using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProgram
{
    /// <summary>
    /// MoodAnalyser class to analyse mood
    /// </summary>
    public class MoodAnalyser
    {
        //class fields
        public string data = "I am In Any Mood";
        /// <summary>
        /// MoodAnalyser() default constructor
        /// </summary>
        public string moodAnalyser()
        {
            if (data.ToLower().Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
        /// <summary>
        /// MoodAnalyser(input) constructor with parameter
        /// </summary>
        public string moodAnalyser(string input)
        {
            var tempArr = input.Split(" ");
            string result = "";
            for (int i = 0; i < tempArr.Length; i++)
            {              
                if (tempArr[i].ToLower().Equals("happy") || tempArr[i].ToLower().Equals("any"))
                {
                    result = "Happy";
                }
                else if (tempArr[i].ToLower().Equals("sad"))
                {
                    result = "Sad";
                }
                else
                {
                    Console.WriteLine("Entered Value Is Null OR Empty");
                    string output = moodAnalyser();
                    result = output;
                }
            }
            return result;
        }  
    }
}
