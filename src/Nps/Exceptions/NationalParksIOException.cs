using System;
using System.Net.Http;

namespace Nps.Exceptions;

public class NationalParksIOException : NationalParksException
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

    public NationalParksIOException(string message, HttpRequestException? innerException = null)
        : base(message, innerException) { }
}
