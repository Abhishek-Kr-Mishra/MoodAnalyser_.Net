using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerUnitTest
{
    [TestClass]
    public class MoodAnalyserUnitTestClass
    {
        [TestMethod]
        public void GivenMood_ShouldReturn_Sad()
        {
            string expected = "Sad";
            string message = "I am Sad";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            Assert.AreEqual(expected, moodAnalyser.AnalyseMood(message));
        }
        [TestMethod]
        public void GivenMethod_ShouldReturn_Happy()
        {
            string expected = "Happy";
            string message = "I am Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            Assert.AreEqual(expected, moodAnalyser.AnalyseMood(message));
        }

    }
}
