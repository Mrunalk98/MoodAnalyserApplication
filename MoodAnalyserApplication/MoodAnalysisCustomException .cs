﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserApplication
{
    public class MoodAnalysisCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_METHOD, NO_SUCH_CLASS
        }

        public readonly ExceptionType type;

        public MoodAnalysisCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

