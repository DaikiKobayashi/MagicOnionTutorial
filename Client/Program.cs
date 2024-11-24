using Grpc.Net.Client;
using MagicOnion.Client;
using Shared.Services;

var channel = GrpcChannel.ForAddress("http://localhost:5000");
var client = MagicOnionClient.Create<ITestService>(channel);

var result = await client.SumAsync(123, 456);
Console.WriteLine($"Result: {result}");