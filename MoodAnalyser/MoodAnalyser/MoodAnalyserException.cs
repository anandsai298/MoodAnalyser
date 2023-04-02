using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD
        }
        public ExceptionType exceptiontype;
        public MoodAnalyserException(ExceptionType type,string Message) :base(Message) 
        {
            this.exceptiontype = type;
        }
    }
}
