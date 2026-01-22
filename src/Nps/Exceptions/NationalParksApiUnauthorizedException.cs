using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksApiUnauthorizedException : NationalParksApi4xxException
{
    public NationalParksApiUnauthorizedException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
