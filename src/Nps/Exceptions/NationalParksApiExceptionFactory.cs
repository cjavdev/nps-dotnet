using System.Net;

namespace Nps.Exceptions;

public class NationalParksApiExceptionFactory
{
    public static NationalParksApiApiException CreateApiException(
        HttpStatusCode statusCode,
        string responseBody
    )
    {
        return (int)statusCode switch
        {
            400 => new NationalParksApiBadRequestException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            401 => new NationalParksApiUnauthorizedException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            403 => new NationalParksApiForbiddenException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            404 => new NationalParksApiNotFoundException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            422 => new NationalParksApiUnprocessableEntityException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            429 => new NationalParksApiRateLimitException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            >= 400 and <= 499 => new NationalParksApi4xxException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            >= 500 and <= 599 => new NationalParksApi5xxException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
            _ => new NationalParksApiUnexpectedStatusCodeException()
            {
                StatusCode = statusCode,
                ResponseBody = responseBody,
            },
        };
    }
}
