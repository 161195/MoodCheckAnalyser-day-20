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

        //An enum (or enumeration type) is used to assign constant names to a group of numeric integer values.
        public enum ExceptionType
        {
            NUll_Type_Exception,
            Empty_Type_Exception,
            Class_Not_Found,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD,
            EMPTY_MESSAGE, 
            NULL_VALUE, 
            NO_SUCH_FIELD, 
            OBJECT_CREATION_ISSUE

        }
        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
