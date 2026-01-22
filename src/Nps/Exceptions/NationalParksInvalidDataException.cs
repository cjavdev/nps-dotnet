using System;

namespace Nps.Exceptions;

public class NationalParksInvalidDataException : NationalParksException
{
    public NationalParksInvalidDataException(string message, Exception? innerException = null)
        : base(message, innerException) { }
}
