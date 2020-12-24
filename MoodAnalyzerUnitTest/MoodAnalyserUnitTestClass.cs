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
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am Sad");
            Assert.AreEqual(expected, moodAnalyser.AnalyseMood());
        }
        [TestMethod]
        public void GivenMethod_ShouldReturn_Happy()
        {
            string expected = "Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am Happy");
            Assert.AreEqual(expected, moodAnalyser.AnalyseMood());
        }

    }
}
