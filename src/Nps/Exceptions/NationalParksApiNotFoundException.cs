using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksApiNotFoundException : NationalParksApi4xxException
{
    public NationalParksApiNotFoundException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
