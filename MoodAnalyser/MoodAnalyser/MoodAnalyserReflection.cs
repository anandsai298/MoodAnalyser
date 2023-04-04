using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyserReflection
    {
        public static object CreateMoodAnalyser(string classname,string constructorname)
        {
            string pattern = @"." + constructorname + "$";
            Match result=Regex.Match(pattern, classname);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = Type.GetType(classname);
                    return Activator.CreateInstance(moodAnalyserType);
                }
                catch(ArgumentNullException) 
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "class not found");
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "constructor not found");
            }
        }
    }
}
