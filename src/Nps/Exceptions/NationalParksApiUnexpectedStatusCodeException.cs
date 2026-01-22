using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksApiUnexpectedStatusCodeException : NationalParksApiApiException
{
    public NationalParksApiUnexpectedStatusCodeException(
        HttpRequestException? innerException = null
    )
        : base(innerException) { }
}
