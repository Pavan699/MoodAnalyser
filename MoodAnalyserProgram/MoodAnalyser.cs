using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace MoodAnalyserProgram
{
    /// <summary>
    /// MoodAnalyser class to analyse mood
    /// </summary>
    public class MoodAnalyser 
    {
        //class fields
        public string data;
        public MoodAnalyser()
        {
            this.data = "Dont know the mood";
        }       
        public MoodAnalyser(string input)
        {
            this.data = input;
        }
        /// <summary>
        /// MoodAnalyser(input) constructor with parameter
        /// </summary>
        public string moodAnalyser()
        {          
            try 
            {              
                if (data.Equals(string.Empty))
                {
                    return "Entered String is Empty";
                    throw new MoodCustom(MoodCustom.custExcep.Empty_String ,"Entered String is Empty");                   
                }
                if (data.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch(NullReferenceException)
            {
                return "You Entered Null";
                throw new MoodCustom(MoodCustom.custExcep.Null_Msg, "You Entered Null");                
            }
            catch (Exception Ex)
            {

                return Ex.Message;
                throw new MoodCustom(MoodCustom.custExcep.Angry_Mood, "User is in Angry Mood");
            }
        }         
    }
}
