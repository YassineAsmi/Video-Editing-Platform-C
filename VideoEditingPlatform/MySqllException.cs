using System;
using System.Runtime.Serialization;

namespace VideoEditingPlatform
{
    [Serializable]
    internal class MySqllException : Exception
    {
        public MySqllException()
        {
        }

        public MySqllException(string message) : base(message)
        {
        }

        public MySqllException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MySqllException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}