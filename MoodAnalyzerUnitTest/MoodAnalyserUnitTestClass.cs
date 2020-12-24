using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerUnitTest
{
    [TestClass]
    public class MoodAnalyserUnitTestClass
    {
        [TestMethod]
        public void GivenMood_ShouldReturn_HappyOrSad()
        {
            string expected = "Sad";
            string message = "I am Sad";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            Assert.AreEqual(expected, moodAnalyser.AnalyseMood(message));
        }
    }
}
