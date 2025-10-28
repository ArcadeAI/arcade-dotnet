using System;
using ArcadeEngine;

namespace ArcadeEngine.Tests;

public class TestBase
{
    protected IArcadeClient client;

    public TestBase()
    {
        client = new ArcadeClient()
        {
            BaseUrl = new Uri(
                Environment.GetEnvironmentVariable("TEST_API_BASE_URL") ?? "http://localhost:4010"
            ),
            APIKey = "My API Key",
        };
    }
}
