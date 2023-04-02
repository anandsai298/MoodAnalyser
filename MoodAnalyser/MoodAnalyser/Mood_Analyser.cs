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
            if (this.msg.Length == 0)
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "message is empty");
            try
            {
                if (this.msg.ToLower().Contains("sad"))
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