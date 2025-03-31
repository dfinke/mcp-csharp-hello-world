using Microsoft.Extensions.Hosting;
using ModelContextProtocol;
using ModelContextProtocol.Server;
using System.ComponentModel;

var builder = Host.CreateEmptyApplicationBuilder(settings: null);

builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithTools();
await builder.Build().RunAsync();

[McpToolType]
public static class Greeting
{
    [McpTool, Description("Get a greeting message for a city")]
    public static string GetGreeting(string city) =>
        $"Hello! Welcome to {city}. Enjoy your stay!";
}