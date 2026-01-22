using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksBadRequestException : NationalParks4xxException
{
    public NationalParksBadRequestException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
