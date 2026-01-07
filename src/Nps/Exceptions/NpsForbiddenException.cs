using System.Net.Http;

namespace Nps.Exceptions;

public class NpsForbiddenException : Nps4xxException
{
    public NpsForbiddenException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
