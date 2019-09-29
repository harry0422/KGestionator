using System;

namespace KGestionator.Domain.Commons.Exceptions
{
    public class ValueObjectIsInvalidException : Exception
    {
        public ValueObjectIsInvalidException(string message) : base(message)
        {

        }
    }
}