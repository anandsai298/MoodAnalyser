namespace MoodAnalyser
{
    public class Mood_Analyser
    {
        string msg;
        public Mood_Analyser(string msg)
        {
            this .msg = msg;
        }
        public string AnalyseMood()
        {
            if (msg.ToLower().Contains("sad"))
                return "SAD";
            return "HAPPY";
        }
    }
}