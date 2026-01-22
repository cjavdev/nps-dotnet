using System;
using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksException : Exception
{
    public NationalParksException(string message, Exception? innerException = null)
        : base(message, innerException) { }

    protected NationalParksException(HttpRequestException? innerException)
        : base(null, innerException) { }
}
