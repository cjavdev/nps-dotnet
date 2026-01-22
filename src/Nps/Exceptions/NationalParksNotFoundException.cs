using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksNotFoundException : NationalParks4xxException
{
    public NationalParksNotFoundException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
