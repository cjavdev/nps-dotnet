using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksApiUnprocessableEntityException : NationalParksApi4xxException
{
    public NationalParksApiUnprocessableEntityException(HttpRequestException? innerException = null)
        : base(innerException) { }
}
