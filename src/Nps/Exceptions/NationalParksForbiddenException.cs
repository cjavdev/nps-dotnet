using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksForbiddenException : NationalParks4xxException
{
    public NationalParksForbiddenException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
