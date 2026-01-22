using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksUnexpectedStatusCodeException : NationalParksApiException
{
    public NationalParksUnexpectedStatusCodeException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
