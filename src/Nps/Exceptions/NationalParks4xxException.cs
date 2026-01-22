using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParks4xxException : NationalParksApiException
{
    public NationalParks4xxException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
