using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksRateLimitException : NationalParks4xxException
{
    public NationalParksRateLimitException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
