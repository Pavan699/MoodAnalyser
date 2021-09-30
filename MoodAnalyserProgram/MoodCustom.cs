using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProgram
{
    public class MoodCustom : Exception
    {
        public enum custExcep
        {
            Null_Msg,
            Empty_String,
            Happy_Mood,
            Sad_Mood,
            Any_Mood,
            Angry_Mood
        }
        public readonly custExcep type;        
        public MoodCustom(custExcep excep, string message) : base(message)
        {
            this.type = excep;            
        }
    }
}
