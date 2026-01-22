using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksUnprocessableEntityException : NationalParks4xxException
{
    public NationalParksUnprocessableEntityException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
