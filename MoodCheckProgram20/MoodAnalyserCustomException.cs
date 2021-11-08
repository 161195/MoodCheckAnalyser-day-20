using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodCheckProgram20
{
    public class MoodAnalyserCustomException : Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            NUll_Type_Exception,
            Empty_Type_Exception,
            Class_Not_Found
        }
        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
