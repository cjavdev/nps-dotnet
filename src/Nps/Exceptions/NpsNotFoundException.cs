using System.Net.Http;

namespace Nps.Exceptions;

public class NpsNotFoundException : Nps4xxException
{
    public NpsNotFoundException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
