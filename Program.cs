using Alice.Attributes;
using Alice.Entities;
using Microsoft.Extensions.DependencyInjection;

ServiceCollection service = new();
AliceTables.Inject(service);

Console.WriteLine("Injected");

[AliceTable("users")]
record User(
    [PrimaryKey] ulong Id
);

public sealed class AliceTables
{
    public static void Inject(ServiceCollection service) => service.AddSingleton<AliceTables>();

    public AliceSqlTable Users = new();
}
