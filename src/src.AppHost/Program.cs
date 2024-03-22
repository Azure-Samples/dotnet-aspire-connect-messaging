var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireMessaging_ApiService>("apiservice");

builder.AddProject<Projects.AspireMessaging_WorkerService>("aspiremessaging-workerservice");

builder.Build().Run();
