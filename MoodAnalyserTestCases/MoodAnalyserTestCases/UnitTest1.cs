using MoodAnalyser;

namespace MoodAnalyserTestCases
{
    public class Tests
    {
        [Test]
        public void GivenSadMood_WhenAnalyse_ShouldReturnSad()
        {
            string msg = "i am in a sad mood";
            Mood_Analyser analyser = new Mood_Analyser(msg);
            string result=analyser.AnalyseMood();
            Assert.AreEqual("SAD",result);
        }
        [Test]
        public void GivenAnyMood_WhenAnalyse_ShouldReturnSad()
        {
            string msg = "i am in a any mood";
            Mood_Analyser analyser = new Mood_Analyser(msg);
            string result = analyser.AnalyseMood();
            Assert.AreEqual("HAPPY", result);
        }
    }
}