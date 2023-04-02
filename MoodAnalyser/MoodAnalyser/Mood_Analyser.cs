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
                if (msg == null)
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD, "message is null");
                if (msg.ToLower().Contains("sad"))
                    return "SAD";
                return "HAPPY";
            }
            catch (Exception)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD,"message is null");
            }
        }
    }
}