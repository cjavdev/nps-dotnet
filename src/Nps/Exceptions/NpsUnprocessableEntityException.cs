using System.Net.Http;

namespace Nps.Exceptions;

public class NpsUnprocessableEntityException : Nps4xxException
{
    public NpsUnprocessableEntityException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
