using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyzer
{
    public class MoodAnalyserReflection
    {
        public static Object CreateMoodAnalysis(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if(result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch(ArgumentNullException)
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionsType.NO_SUCH_CLASS_FOUND, "There is no such Class Avaliable");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionsType.NO_SUCH_METHOD,"Im-proper Constructor Name");
            }
        }
        public static Object CreateMoodAnalysisInParameterConstructor(string className, string constructorName)
        {
            Type type = typeof(MoodAnalyser);
            if (type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object insstance = ctor.Invoke(new object[] { "HAPPY" });
                    return insstance;
                }
                else
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionsType.NO_SUCH_METHOD, "Im-proper Constructor Name");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionsType.NO_SUCH_CLASS_FOUND, "There is no such Class Avaliable");
            }
        }
    }
}
