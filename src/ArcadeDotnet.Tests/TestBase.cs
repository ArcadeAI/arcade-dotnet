using System;
using System.Net.Http;
using ArcadeDotnet;

namespace ArcadeDotnet.Tests;

public abstract class TestBase
{
    protected readonly IArcadeClient Client;

    protected TestBase()
    {
        Client = new ArcadeClient(new ArcadeClientOptions
        {
            BaseUrl = new Uri(
                Environment.GetEnvironmentVariable("TEST_API_BASE_URL") ?? "http://localhost:4010"
            ),
            ApiKey = "My API Key",
            HttpClient = new HttpClient()
        });
    }
}
