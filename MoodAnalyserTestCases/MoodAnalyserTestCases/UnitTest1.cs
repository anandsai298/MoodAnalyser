using MoodAnalyser;

namespace MoodAnalyserTestCases
{
    public class Tests
    {
        [Test]
        public void GivenSadMood_WhenAnalyse_ShouldReturnSad()
        {
            string msg = "i am in a sad mood";
            Mood_Analyser analyser = new Mood_Analyser();
            string result=analyser.AnalyseMood(msg);
            Assert.AreEqual("SAD",result);
        }
    }
}