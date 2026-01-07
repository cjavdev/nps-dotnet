using System.Net.Http;

namespace Nps.Exceptions;

public class NpsUnauthorizedException : Nps4xxException
{
    public NpsUnauthorizedException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
