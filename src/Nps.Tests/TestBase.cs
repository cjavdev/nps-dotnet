using System;
using Nps;

namespace Nps.Tests;

public class TestBase
{
    protected INpsClient client;

    public TestBase()
    {
        client = new NpsClient()
        {
            BaseUrl =
                Environment.GetEnvironmentVariable("TEST_API_BASE_URL") ?? "http://localhost:4010",
            ApiKey = "My API Key",
        };
    }
}
