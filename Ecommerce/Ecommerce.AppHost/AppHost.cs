using Microsoft.Extensions.DependencyInjection;
using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var productApi = builder.AddProject<Ecommerce_ProductService>("apiservice-product");
var orderApi = builder.AddProject<Ecommerce_OrderService>("apiservice-order");

builder.AddProject<Ecommerce_Web>("webFrontend")
    .WithReference(productApi) 
    .WithReference(orderApi);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
      policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

builder.Build().Run();
