# BlazorGrpc
An example to demonstrate ASP.NET Core support of such technologies as Blazor and gRPC.

## How to launch locally
Once downloaded/cloned, open the solution file located in the root. It consists of three projects:
- *AspNetCoreMentoring* contains Blazor WebAssembly progressive web app, running in standalone mode.
- *GrpcService* contains an app exposing a single gRPC 'greeter' endpoint.
- *GrpcShared*, referenced by both executables above, contains shared definitions for gRPC service, request, and response.

After installing NuGet packages and rebuilding the project, publish and launch the web application. As a quick and convenient solution for Windows users, it is recommended to publish the project to a folder, then launch it using IIS Express.

Once the web application is deployed, set the GrpcService as a startup project and start it directly from VS. By default, the Kestrel server will be hosting it.

Open the web application in the browser, go to the 'gRPC' tab, and see how gRPC requests and responses are getting through the network via the DevTools.

## Home task
### Learn gRPC and Blazor fundamentals
Check out the materials in sections below, explore this example. If necessary, ask your mentor for help in understanding.
### Enable gRPC services on Northwind Web API
There should be a new gRPC service developed that exposes a new endpoint responding with the most recent order by order date. Return flat object (without dependencies).
### Create gRPC web client upon Blazor WebAssembly app
Using the sample Blazor app in this repo, create a new page that requests for the most recent order from the gRPC service. Visualize the response in a table.
### Deploy to Azure (optional)
If you are familiar with Azure stack, consider deploying both gRPC service and Blazor app to separate Azure App Service instances. Validate the behavior.

## Additional reading
- gRPC services with C#: https://docs.microsoft.com/en-us/aspnet/core/grpc/basics?view=aspnetcore-3.1
- Tutorial: Create a gRPC client and server in ASP.NET Core: https://docs.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start?view=aspnetcore-3.1
- Introduction to ASP.NET Core Blazor: https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-3.1

## Additional lectures (videos)
- ASP.NET Core Series: Blazor: https://channel9.msdn.com/Shows/On-NET/ASPNET-Core-Series-Blazor
- ASP.NET - Introducing Blazor: Razor Components: https://channel9.msdn.com/Series/ASPNET-Core-101/ASPNET-Introducing-Blazor-Razor-Components-10-of-13
- ASP.NET - Introducing Blazor: Structure and Debugging: https://channel9.msdn.com/Series/ASPNET-Core-101/ASPNET-Introducing-Blazor-Structure-and-Debugging-11-of-13
- ASP.NET - Introducing Blazor: Interactivity: https://channel9.msdn.com/Series/ASPNET-Core-101/ASPNET-Introducing-Blazor-Interactivity-12-of-13
