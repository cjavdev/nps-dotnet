using System;
using System.Net.Http;

namespace Nps.Exceptions;

public class NpsException : Exception
{
    public NpsException(string message, Exception? innerException = null)
        : base(message, innerException) { }

    protected NpsException(HttpRequestException? innerException)
        : base(null, innerException) { }
}
