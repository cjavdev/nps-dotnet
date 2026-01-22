using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksApiForbiddenException : NationalParksApi4xxException
{
    public NationalParksApiForbiddenException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
