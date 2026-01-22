using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksApi5xxException : NationalParksApiApiException
{
    public NationalParksApi5xxException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
