using System.Net.Http;

namespace Nps.Exceptions;

public class Nps5xxException : NpsApiException
{
    public Nps5xxException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
