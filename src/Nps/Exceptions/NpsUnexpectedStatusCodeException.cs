using System.Net.Http;

namespace Nps.Exceptions;

public class NpsUnexpectedStatusCodeException : NpsApiException
{
    public NpsUnexpectedStatusCodeException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
