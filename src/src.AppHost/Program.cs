var builder = DistributedApplication.CreateBuilder(args);

var serviceBus = builder.ExecutionContext.IsPublishMode
    ? builder.AddAzureServiceBus("messaging")
    : builder.AddConnectionString("messaging");

var apiService = builder.AddProject<Projects.AspireMessaging_ApiService>("apiservice")
       .WithReference(serviceBus);

builder.AddProject<Projects.AspireMessaging_WorkerService>("aspiremessaging-workerservice");

builder.Build().Run();
