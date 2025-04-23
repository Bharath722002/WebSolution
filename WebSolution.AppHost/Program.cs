var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ManufactureApi>("manufactureapi");

builder.AddProject<Projects.Manu>("manu");

builder.Build().Run();
