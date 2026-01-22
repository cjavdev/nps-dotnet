using System;
using Nps;

namespace Nps.Tests;

public class TestBase
{
    protected INationalParksClient client;

    public TestBase()
    {
        client = new NationalParksClient()
        {
            BaseUrl =
                Environment.GetEnvironmentVariable("TEST_API_BASE_URL") ?? "http://localhost:4010",
            ApiKey = "My API Key",
        };
    }
}
