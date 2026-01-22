using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksUnauthorizedException : NationalParks4xxException
{
    public NationalParksUnauthorizedException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
