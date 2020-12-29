using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;

namespace MoodAnalyzerUnitTest
{
    [TestClass]
    public class MoodAnalyserUnitTestClass
    {
        //T.C-1.1
        [TestMethod]
        public void GivenMood_ShouldReturn_Sad()
        {
            string expected = "Sad";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am Sad");
            Assert.AreEqual(expected, moodAnalyser.AnalyseMood());
        }
        //T.C-1.2
        [TestMethod]
        public void GivenMethod_ShouldReturn_Happy()
        {
            string expected = "Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am Happy");
            Assert.AreEqual(expected, moodAnalyser.AnalyseMood());
        }
        //T.C-2.1
        //[TestMethod]
        //public void GivenNullMood_ShouldReturn_Happy()
        //{
        //    string expected = "Happy";
        //    MoodAnalyser moodAnalyser = new MoodAnalyser(null);
        //    Assert.AreEqual(expected, moodAnalyser.AnalyseMood());
        //}
        //T.C-3.1
        [TestMethod]
        [DataRow("")]
        public void GivenMoodEmpty_ShouldThrow_MoodAnalysisEmptyTypeException(string message)
        {
            try
            {
                string expected = "Happy";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                Assert.AreEqual(expected, moodAnalyser.AnalyseMood());
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Message Should not Be Empty", e.Message);
            }
        }
        //T.C-3.2
        [TestMethod]
        [DataRow(null)]
        public void GivenMoodNull_ShouldThrow_MoodAnalysisNullTypeException(string message)
        {
            try
            {
                string expected = "Happy";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                Assert.AreEqual(expected, moodAnalyser.AnalyseMood());
            }
            catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Message Should Not be Null", e.Message);
            }
        }
    }
}
