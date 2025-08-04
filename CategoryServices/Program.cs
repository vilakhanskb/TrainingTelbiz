using CategoryServices.Services;
using Couchbase.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();


builder.Services.AddCouchbase(client =>
{
    client.ConnectionString = "couchbase://127.0.0.1";
    client.UserName = "Administrator";
    client.Password = "1qaz2wsx";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");



app.Run();
