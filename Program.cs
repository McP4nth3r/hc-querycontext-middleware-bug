// See https://aka.ms/new-console-template for more information

using ConsoleApp12.Schema;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddConsoleApp12Types()
    .AddQueryContext()
    .AddSorting()
    .AddFiltering()
    .AddProjections()
    .AddPagingArguments()
    .AddQueryConventions();
    //.UseField<MaintenanceModeMiddleware>();

var app = builder.Build();

app.MapGraphQL();

app.Run();