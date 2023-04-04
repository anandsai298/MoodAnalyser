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
        public static object CreateMoodAnalyserUsingParametrisedConstructor(string classname, string constructorname,string msg)
        {
            Type type = typeof(Mood_Analyser);
            if (type.Name.Equals(classname) || type.FullName.Equals(classname))
            {
                if(type.Name.Equals(constructorname))
                {
                    ConstructorInfo constr = type.GetConstructor(new[] { typeof(string) });
                    object instance = constr.Invoke(new object[] { msg });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "constructor not found");
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "class not found");
            }
        }
    }
}
