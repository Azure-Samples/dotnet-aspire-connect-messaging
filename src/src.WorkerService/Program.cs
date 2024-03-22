using AspireMessaging.WorkerService;
using Azure.Identity;

var builder = Host.CreateApplicationBuilder(args);
builder.AddAzureServiceBus("messaging");
builder.AddServiceDefaults();
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
