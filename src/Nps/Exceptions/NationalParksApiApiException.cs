using System;
using System.Net;
using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksApiApiException : NationalParksApiException
{
    public new HttpRequestException InnerException
    {
        get
        {
            if (base.InnerException == null)
            {
                throw new ArgumentNullException();
            }
            return (HttpRequestException)base.InnerException;
        }
    }

    public NationalParksApiApiException(string message, HttpRequestException? innerException = null)
        : base(message, innerException) { }

    protected NationalParksApiApiException(HttpRequestException? innerException)
        : base(innerException) { }

    public required HttpStatusCode StatusCode { get; init; }

    public required string ResponseBody { get; init; }

    public override string Message
    {
        get { return string.Format("Status Code: {0}\n{1}", StatusCode, ResponseBody); }
    }
}
