using System;

namespace BookManagementSystem.Tools.Exceptions
{
    public class ProcessingException : Exception
    {
        public ProcessingException(string message)
            : base(message)
        {
        }
    }
}