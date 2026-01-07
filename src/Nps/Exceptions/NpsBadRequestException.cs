using System.Net.Http;

namespace Nps.Exceptions;

public class NpsBadRequestException : Nps4xxException
{
    public NpsBadRequestException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
