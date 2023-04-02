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
            try
            {
                if (msg.ToLower().Contains("sad"))
                    return "SAD";
                return "HAPPY";
            }
            catch (Exception)
            {
                return "HAPPY";
            }
        }
    }
}