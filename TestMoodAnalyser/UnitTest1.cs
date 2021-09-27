using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProgram;

namespace TestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {       
            MoodAnalyser result1 = new MoodAnalyser();//Arrange 
            string res = result1.moodAnalyser("I am Happy");
            Assert.AreEqual("Happy", res);//Assert
        }
    }
}
