using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksApiBadRequestException : NationalParksApi4xxException
{
    public NationalParksApiBadRequestException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
