using AspireMessaging.WorkerService;
using Azure.Identity;

var builder = Host.CreateApplicationBuilder(args);
builder.AddAzureServiceBus("messaging",
    options =>
    {
        options.Namespace = "{your-namespace}.servicebus.windows.net";
        options.Credential = new DefaultAzureCredential();
    });
builder.AddServiceDefaults();
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
