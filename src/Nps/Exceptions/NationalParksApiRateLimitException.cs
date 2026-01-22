using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksApiRateLimitException : NationalParksApi4xxException
{
    public NationalParksApiRateLimitException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
