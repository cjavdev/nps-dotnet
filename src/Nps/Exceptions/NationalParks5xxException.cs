using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParks5xxException : NationalParksApiException
{
    public NationalParks5xxException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
