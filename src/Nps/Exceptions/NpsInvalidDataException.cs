using System;

namespace Nps.Exceptions;

public class NpsInvalidDataException : NpsException
{
    public NpsInvalidDataException(string message, Exception? innerException = null)
        : base(message, innerException) { }
}
