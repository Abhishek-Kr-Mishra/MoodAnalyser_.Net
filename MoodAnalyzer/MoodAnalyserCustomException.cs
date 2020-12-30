using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionsType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_CLASS_FOUND ,NO_SUCH_METHOD,
        }
        public ExceptionsType type;
        public MoodAnalyserCustomException(ExceptionsType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
