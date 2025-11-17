using System;
using System.Net.Http;
using System.Threading.Tasks;
using ArcadeDotnet;
using ArcadeDotnet.Models.Tools;
using ArcadeDotnet.Exceptions;
using ArcadeDotnet.Models;

namespace Examples;

/// <summary>
/// Basic example demonstrating how to use the Arcade SDK.
/// </summary>
class Program
{
    static async Task Main(string[] args)
    {
        // Create client using environment variables
        var client = new ArcadeClient();
        Console.WriteLine($"Connected to: {client.BaseUrl}\n");

        // Example 1: Execute a Simple Tool (No OAuth Required)
        Console.WriteLine("=== Example 1: Execute Simple Tool (No OAuth) ===");
        Console.WriteLine("   Note: Most tools require OAuth. This example shows the pattern.");
        Console.WriteLine("   For a working example, use a tool that doesn't require authentication.");
        try
        {
            // Example: Execute a tool (this will likely require UserID for most tools)
            // In practice, you'd use a tool that doesn't need OAuth like math operations
            var executeParams = new ToolExecuteParams
            {
                ToolName = "CheckArcadeEngineHealth", // Example tool name
                // UserID = "user-id" // Required for most tools
            };

            var result = await client.Tools.Execute(executeParams);
            result.Validate();

            Console.WriteLine($"✅ Tool executed successfully!");
            Console.WriteLine($"   Execution ID: {result.ExecutionID}");
            Console.WriteLine($"   Status: {result.Status}");
            Console.WriteLine($"   Success: {result.Success}");
        }
        catch (ArcadeBadRequestException ex)
        {
            Console.WriteLine($"   ⚠️ Expected: Most tools require UserID or specific parameters");
            Console.WriteLine($"   Error: {ex.Message}");
            Console.WriteLine($"   Tip: Use Tools.Authorize() first for OAuth tools");
        }
        catch (ArcadeNotFoundException ex)
        {
            Console.WriteLine($"❌ Tool not found: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error: {ex.GetType().Name}: {ex.Message}");
        }

        // Example 2: Execute Tool Requiring OAuth (GitHub Example)
        Console.WriteLine("\n=== Example 2: Tool Requiring OAuth (GitHub) ===");
        try
        {
            // For tools requiring OAuth, you need to authorize first
            // This example shows the pattern (GitHub tools require OAuth)
            var authorizeParams = new ToolAuthorizeParams
            {
                ToolName = "GitHub.ListRepositories" // Example GitHub tool
            };

            Console.WriteLine("   Authorizing tool access...");
            var authResponse = await client.Tools.Authorize(authorizeParams);
            authResponse.Validate();

            Console.WriteLine($"   ✅ Authorization initiated!");
            if (authResponse.Status != null)
            {
                Console.WriteLine($"   Status: {authResponse.Status.Value}");
            }
            if (!string.IsNullOrEmpty(authResponse.URL))
            {
                Console.WriteLine($"   OAuth URL: {authResponse.URL}");
            }
            Console.WriteLine($"   Note: Complete OAuth flow, then use UserID in Execute()");

            // After OAuth completes, execute with UserID:
            // var executeParams = new ToolExecuteParams
            // {
            //     ToolName = "GitHub.ListRepositories",
            //     UserID = "user-id-from-oauth-flow"
            // };
        }
        catch (ArcadeNotFoundException ex)
        {
            Console.WriteLine($"   ⚠️ Tool not found (this is expected if GitHub tools aren't available)");
            Console.WriteLine($"   Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"   ⚠️ Error: {ex.GetType().Name}: {ex.Message}");
            Console.WriteLine("   Note: This demonstrates the OAuth authorization pattern");
        }

        // Example 3: List Available Tools
        Console.WriteLine("\n=== Example 3: List Available Tools ===");
        try
        {
            var tools = await client.Tools.List();
            tools.Validate();
            var count = tools.Items?.Count ?? 0;
            Console.WriteLine($"✅ Found {count} available tools");

            if (tools.Items != null && tools.Items.Count > 0)
            {
                Console.WriteLine($"   First tool: {tools.Items[0].Name}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error: {ex.GetType().Name}: {ex.Message}");
        }

        // Example 4: Get Tool Details
        Console.WriteLine("\n=== Example 4: Get Tool Details ===");
        try
        {
            var toolParams = new ToolGetParams { Name = "Google.ListEmails" };
            var tool = await client.Tools.Get(toolParams);
            tool.Validate();
            Console.WriteLine($"✅ Tool retrieved: {tool.Name}");
            Console.WriteLine($"   Description: {tool.Description ?? "N/A"}");
        }
        catch (ArcadeNotFoundException ex)
        {
            Console.WriteLine($"❌ Tool not found: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error: {ex.GetType().Name}: {ex.Message}");
        }

        // Example 5: Health Check
        Console.WriteLine("\n=== Example 5: Health Check ===");
        try
        {
            var health = await client.Health.Check();
            health.Validate();
            Console.WriteLine($"✅ Health check passed: {health.Healthy}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Error: {ex.GetType().Name}: {ex.Message}");
        }
    }
}
