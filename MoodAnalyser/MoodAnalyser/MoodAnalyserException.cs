using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD,EMPTY_MOOD, NO_SUCH_CLASS, NO_SUCH_METHOD
        }
        public ExceptionType exceptiontype;
        public MoodAnalyserException(ExceptionType type,string msg) :base(msg) 
        {
            this.exceptiontype = type;
        }
    }
}
