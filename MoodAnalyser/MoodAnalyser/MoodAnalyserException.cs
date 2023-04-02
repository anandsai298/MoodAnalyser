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
            NULL_MOOD,EMPTY_MOOD
        }
        public ExceptionType exceptiontype;
        public MoodAnalyserException(ExceptionType type,string msg) :base(msg) 
        {
            this.exceptiontype = type;
        }
    }
}
