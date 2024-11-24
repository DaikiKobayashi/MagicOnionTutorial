using Grpc.Net.Client;
using MagicOnion.Client;
using Shared.Services;

var channel = GrpcChannel.ForAddress("https://localhost:5001");
var client = MagicOnionClient.Create<ITestService>(channel);

var result = await client.SumAsync(123, 456);
Console.WriteLine($"Result: {result}");