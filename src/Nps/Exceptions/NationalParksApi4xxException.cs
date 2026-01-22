using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksApi4xxException : NationalParksApiApiException
{
    public NationalParksApi4xxException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
