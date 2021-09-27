using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProgram
{
    class MoodAnalyser
    {
        public string Check(string input)
        {
            if(input.ToLower().Contains("sad"))
            {
                return "Sad";
            }
            return "Happy";
        }
    }
}
