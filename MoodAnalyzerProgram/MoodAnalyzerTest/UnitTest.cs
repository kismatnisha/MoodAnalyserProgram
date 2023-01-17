
using MoodAnalyzerProgram;

namespace MoodAnalyzerTest

{
    [TestClass]
    public class UnitTest
    {
        //UC2
        // TC 2.1: Given null mood Should Return HAPPY
        [TestMethod]
        public void GivenNullMoodShouldReturnHAPPY()
        {
            string expected = "HAPPY";
            string message = null;
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
            string mood = moodAnalyse.AnalyzeMood();
            Assert.AreEqual(expected, mood);
        }
    }
}