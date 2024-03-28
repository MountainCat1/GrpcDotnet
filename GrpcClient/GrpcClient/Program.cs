using Grpc.Net.Client;
using GrpcServer;

using var channel = GrpcChannel.ForAddress("http://localhost:5275");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = "World" });
Console.WriteLine("Greeting: " + reply.Message);