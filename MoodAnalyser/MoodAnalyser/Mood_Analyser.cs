namespace MoodAnalyser
{
    public class Mood_Analyser
    {
        public string AnalyseMood(string msg)
        {
            if (msg.ToLower().Contains("sad"))
                return "SAD";
            return "HAPPY";
        }
    }
}