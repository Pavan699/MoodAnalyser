using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProgram;

namespace TestMoodAnalyser
{
    /// <summary>
    /// Class to test the cases and handle the exceptions while testing
    /// </summary>
    [TestClass]
    public class UnitTest1
    {       
        /// <summary>
        /// method to test the Sad Mood
        /// </summary>
        [TestMethod]
        public void TestMethodSad()
        {
            MoodAnalyser result1 = new MoodAnalyser("I am sad mood");//Arrange 
            string res = result1.moodAnalyser();
            Assert.AreEqual("Sad", res);//Assert
        }
        /// <summary>
        /// Method to test the Happy mood 
        /// </summary>
        [TestMethod]
        public void TestMethodHappy()
        {       
            MoodAnalyser result1 = new MoodAnalyser("I am any mood");//Arrange 
            string res = result1.moodAnalyser();
            Assert.AreEqual("Happy", res);//Assert
        }

        [TestMethod]
        public void TestMethodEmpty()
        {
            try
            {
                MoodAnalyser result = new MoodAnalyser("");//Arrange           
                string res = result.moodAnalyser();
            }
            catch(MoodCustom ma)
            {
                Assert.AreEqual("Entered String is Empty", ma.Message);
            }
        }
    }
}
