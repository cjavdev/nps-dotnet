using System.Net.Http;

namespace Nps.Exceptions;

public class NpsRateLimitException : Nps4xxException
{
    public NpsRateLimitException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
