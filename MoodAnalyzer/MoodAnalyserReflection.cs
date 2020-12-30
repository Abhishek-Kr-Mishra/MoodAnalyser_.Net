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
        public static string CreateMoodAnalysisInParameterMethod(string methodName, string fieldName)
        {
            Type moodAnalysertype = Type.GetType("MoodAnalyzer.MoodAnalyser");
            MethodInfo methodInfo = moodAnalysertype.GetMethod(methodName);
            string[] stringArray = { "I am in Happy mood" };
            object objectInstance = Activator.CreateInstance(moodAnalysertype, stringArray);
            try
            {
                if (fieldName != null)
                {
                    FieldInfo fieldInfo = moodAnalysertype.GetField(fieldName);
                    if (fieldInfo == null)
                        return "" + MoodAnalyserCustomException.ExceptionsType.NULL_MESSAGE;
                    fieldInfo.SetValue(objectInstance, fieldName);
                }
            }
            catch (MoodAnalyserCustomException)
            {
                return "No_Such_Field_Exception";
            }
            try
            {
                if (fieldName == null)
                {
                    return "" + MoodAnalyserCustomException.ExceptionsType.NULL_MESSAGE;
                }
            }
            catch (MoodAnalyserCustomException)
            {
                return "NULL_EXCEPTION";
            }
            try
            {
                if (methodInfo == null)
                {
                    return "" + MoodAnalyserCustomException.ExceptionsType.NO_SUCH_METHOD;
                }

                string method = (string)methodInfo.Invoke(objectInstance, null);
                return method;
            }
            catch (MoodAnalyserCustomException)
            {
                return "HAPPY";
            }
        }
    }
}
