using System;
using System.Net.Http;

namespace Nps.Exceptions;

public class NpsIOException : NpsException
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

    public NpsIOException(string message, HttpRequestException? innerException = null)
        : base(message, innerException) { }
}
