using System.Net.Http;

namespace Nps.Exceptions;

public class Nps4xxException : NpsApiException
{
    public Nps4xxException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
