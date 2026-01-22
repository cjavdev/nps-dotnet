using System;

namespace Nps.Exceptions;

public class NationalParksApiInvalidDataException : NationalParksApiException
{
    public NationalParksApiInvalidDataException(string message, Exception? innerException = null)
        : base(message, innerException) { }
}
