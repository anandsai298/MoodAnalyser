using MoodAnalyzer;

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
        [Test]
        public void GivenNullMood_WhenAnalyse_ShouldReturnSad()
        {
            try
            {
                string msg = null;
                Mood_Analyser analyser = new Mood_Analyser(msg);
                string result = analyser.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "message is null");
            }
        }
        [Test]
        public void GivenEmptyMood_WhenAnalyse_ShouldReturnSad()
        {
            try
            {
                string msg = "";
                Mood_Analyser analyser = new Mood_Analyser(msg);
                string result = analyser.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "message is empty");
            }
        }
        [Test]
        public void GetMoodAnalyserClassName_ShouldReturn_MoodAnalyserObject()
        {
            string msg = null;
            object expected = new Mood_Analyser(msg);
            object obj = MoodAnalyserReflection.CreateMoodAnalyser("MoodAnalyzer.Mood_Analyser", "Mood_Analyser");
            expected.Equals(obj);
            //Assert.AreEqual (expected, obj);
        }
        [Test]
        public void GetMoodAnalyserClassName_ShouldReturnMoodAnalyserObject_UsingParameterisedConstructor()
        {
            object expected = new Mood_Analyser("HAPPY");
            object obj = MoodAnalyserReflection.CreateMoodAnalyserUsingParametrisedConstructor("MoodAnalyzer.Mood_Analyser", "Mood_Analyser", "HAPPY");
            expected.Equals(obj);
            //Assert.AreEqual (expected, obj);
        }
    }
}