var builder = DistributedApplication.CreateBuilder(args);




var compose = builder.AddDockerComposeEnvironment("compose");

var apiService = builder.AddProject<Projects.AspireDeployDemo_ApiService>("apiservice")
    .PublishAsDockerComposeService((resource, service) =>
    {
        service.Name = "apiservice998";
    })
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.AspireDeployDemo_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
