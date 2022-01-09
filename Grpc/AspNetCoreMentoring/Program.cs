using System;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using GrpcShared;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreMentoring
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(services => new HttpClient
                {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});
            builder.Services.AddSingleton(services =>
            {
                // Create a gRPC-Web channel pointing to the backend server
                var httpClient = new HttpClient(new GrpcWebHandler(GrpcWebMode.GrpcWeb, new HttpClientHandler()));
                var channel = GrpcChannel.ForAddress("https://localhost:5002",
                    new GrpcChannelOptions {HttpClient = httpClient});

                // Now we can instantiate gRPC clients for this channel
                return new Greeter.GreeterClient(channel);
            });

            await builder.Build().RunAsync();
        }
    }
}