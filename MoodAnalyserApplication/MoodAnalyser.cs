

using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserApplication
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                    throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty string");
                if (this.message.ToLower().Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }

        }
    }
}