using System;

namespace LinqExceptions
{
    class NUllData : Exception
    {
        public override string Message { get; }

        public NUllData(in string message)
        {
            Message = message;
        }
    }
}
