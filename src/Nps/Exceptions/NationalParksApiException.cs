using System;
using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksApiException : Exception
{
    public NationalParksApiException(string message, Exception? innerException = null)
        : base(message, innerException) { }

    protected NationalParksApiException(HttpRequestException? innerException)
        : base(null, innerException) { }
}
